<template>
    <div class="gray-bg">

        <div class="middle-box text-center loginscreen   animated fadeInDown">
            <div>
                <div>

                    <h1 class="logo-name">{{PRODUCT_NAME}}</h1>

                </div>
                <h3>Register with {{PRODUCT_NAME}}</h3>
                <p>Create account to see it in action.</p>
                <form class="m-t" role="form" action="#">
                    <div class="form-group">
                        <input 
                               type="text"
                               class="form-control"
                               placeholder="Display Name"
                               v-model="register.displayName"
                               required="">
                    </div>
                    <div class="form-group">
                        <input 
                               type="text"
                               class="form-control"
                               placeholder="User Name"
                               v-model="register.userName"
                               required="">
                    </div>
                    <div class="form-group">
                        <input 
                               type="email"
                               class="form-control"
                               placeholder="Email"
                               v-model="register.email"
                               required="">
                    </div>
                    <div class="form-group">
                        <input 
                               type="password"
                               class="form-control"
                               placeholder="Password"
                               v-model="register.password"
                               required="">
                    </div>
                    <div class="form-group">
                        <input 
                               type="password"
                               class="form-control"
                               placeholder="Re Password"
                               v-model="register.rePassword"
                               required="">
                    </div>
                    <div class="form-group">
                        <div class="checkbox"><label> <input type="checkbox" v-model="agree" id="agreebutton"><i></i> Agree the terms and policy </label></div>

                    </div>

                    <button-spinner type="submit"
                                    spinnerClass="btn btn-primary block full-width m-b"
                                    @click.native="serviceRegister()"
                                    v-bind="{isLoading, status}"
                                    :disabled="isLoading">Register</button-spinner>

                    <p class="text-muted text-center"><small>Already have an account?</small></p>
                    <a class="btn btn-sm btn-white btn-block" href="login">Login</a>
                </form>
                <p class="m-t"> <small>{{COMPANY_NAME}} &copy; 2019</small> </p>
            </div>
        </div>
    </div>

</template>
<script>
    import { REGISTER } from "../common/constants/url";
    import { _VALUES } from "../common/constants/values";
    import {
        required,
        email,
        minLength,
        maxLength
    } from "vuelidate/lib/validators";
    import ButtonSpinner from "../components/SpinnerButton.vue";
    import requestModule from "../common/utils/RequsetModule";
    export default {
        name: "register-component",
        components: {
            ButtonSpinner
        },
        data: function () {
            return {
                PRODUCT_NAME: _VALUES.PRODUCT_NAME,
                COMPANY_NAME: _VALUES.COMPANY_NAME,
                ROLE_NAMES: _VALUES.USERS,
                register: {
                    displayName: "",
                    userName: "",
                    email: "",
                    password: "",
                    rePassword:""
                },
                agree:false,
                isLoading: false,
                status: "",
                hasError: false,
                validationTexts: _VALUES,
                toastOptions: {
                    closeButton: true,
                    debug: false,
                    progressBar: true,
                    positionClass: "toast-top-right",
                    onclick: null,
                    showDuration: 400,
                    hideDuration: 1000,
                    timeOut: 7000,
                    extendedTimeOut: 1000,
                    showEasing: "swing",
                    hideEasing: "linear",
                    showMethod: "fadeIn",
                    hideMethod: "fadeOut"
                },
            };
        },
        props: {
            indexUrl: String,
            loginUrl: String,
        },
        validations: {
            register: {
                displayName: { required },
                userName: { required },
                email: { required, email},
                password: {
                    required,
                    minLength: minLength(_VALUES.PASSWORD_LENGTH_MIN),
                    maxLength: maxLength(_VALUES.PASSWORD_LENGTH_MAX)
                },
                 rePassword: {required}
            },
           
        },
        methods: {

            serviceRegister() {
                var vm = this;
                this.$v.register.$touch();
                var passwordsMatch = this.register.password === this.register.rePassword;
                if (!passwordsMatch) {
                    vm.hasError = true;
                    vm.showWarningMsg( "Invalid","The password confirmation does not match. ");
                }
                if (!vm.agree) {
                    vm.hasError = true;
                    vm.showWarningMsg("Warning","Agree the terms and policy. " );
                }
                if (!vm.agree || !passwordsMatch || this.$v.register.$error) return;

                var model =
                {
                    displayName: vm.register.displayName,
                    userName: vm.register.userName,
                    email: vm.register.email,
                    password: vm.register.password,
     

                }

                this.isLoading = true;
                requestModule()
                    .post(REGISTER, vm.register)
                    .then(response => {
                        vm.isLoading = false;
                        console.log(response);
                        if (response.data.status == "Success") {
                            vm.status = true;
                            vm.showSuccessMsg("Account Created", "Login to access your account");
                            window.location.href = vm.indexUrl;
                        } else if (response.data.status == "Error") {
                            vm.showErrorMsg("Oops", response.data.message);
                        } else
                        {
                            vm.showWarningMsg("Error", "Something went wrong.. Please try again later.");
                        }
                    })
                    .catch(function (err) {
                        console.log(response);
                        if (err.response.status === 400) {
                            //vm.errors = err.response.data.errors;
                            vm.hasError = true;
                            vm.showErrorMsg("Oops", response.data.message);
                        }
                        vm.isLoading = false;
                        vm.status = "";
                        console.log(err);
                    });
            },

            showWarningMsg(title, msg) {
                toastr.options = this.toastOptions;
                var $toast = toastr["warning"](msg, title);
            },
            showSuccessMsg(title, msg) {
                toastr.options = this.toastOptions;
                var $toast = toastr["success"](msg, title);
            },
            showErrorMsg(title, msg) {
                toastr.options = this.toastOptions;
                var $toast = toastr["error"](msg, title);
            },


        },

    };
</script>