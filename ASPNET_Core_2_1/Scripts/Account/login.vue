<template>
    <div id="login">
        <div class="gray-bg">

            <div class="loginColumns animated fadeInDown">
                <div class="row">

                    <div class="col-md-6">
                        <h2 class="font-bold">Welcome to {{PRODUCT_NAME}}</h2>

                        <p>
                            Perfectly designed and precisely prepared admin theme with over 50 pages with extra new web app views.
                        </p>

                        <p>
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
                        </p>

                        <p>
                            When an unknown printer took a galley of type and scrambled it to make a type specimen book.
                        </p>

                        <p>
                            <small>It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</small>
                        </p>

                    </div>
                    <div class="col-md-6">
                        <div class="ibox-content">
                            <form class="m-t" role="form">
                                <div class="form-group">
                                    <input type="email" class="form-control" placeholder="Email" v-model="login.username" required="">
                                </div>
                                <div class="form-group">
                                    <input type="password" class="form-control" placeholder="Password" v-model="login.password" required="">
                                </div>
                                <div class="error active"
                                     v-if="this.$v.login.$error || hasError">Invalid user name or password</div>



                                <button-spinner type="submit"
                                                spinnerClass="btn btn-primary block full-width m-b"
                                                @click.native="serviceLogin()"
                                                v-bind="{isLoading, status}"
                                                :disabled="isLoading">Login</button-spinner>

                                <button-spinner type="submit"
                                                spinnerClass="btn btn-primary block full-width m-b"
                                                @click.native="loginGuest()"                                              
                                                :disabled="isLoading">Login As Guest</button-spinner>



                                <div class="clr-row" style="margin-top: 10px; margin-left: 20px">
                                    <div class="clr-col-md-4"></div>
                                    <div class="clr-col-md-4">
                                        <div class="g-signin2" data-onsuccess="onSignIn"></div>
                                    </div>
                                    <div class="clr-col-md-4"></div>
                                </div>

                                <a href="forgotpassword">
                                    <small>Forgot password?</small>
                                </a>

                                <p class="text-muted text-center">
                                    <small>Do not have an account?</small>
                                </p>
                                <a class="btn btn-sm btn-white btn-block" href="register">Create an account</a>
                            </form>
                            <p class="m-t">
                                <small>{{COMPANY_NAME}} &copy; 2019</small>
                            </p>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-6">
                        Copyright {{COMPANY_NAME}}
                    </div>
                    <div class="col-md-6 text-right">
                        <small>© 2019-2020</small>
                    </div>
                </div>
            </div>

        </div>
    </div>

</template>
<script>
    import { LOGIN } from "../common/constants/url";
    import { _VALUES } from "../common/constants/values";
    import {
      required,
      email,
      minLength,
      maxLength
    } from "vuelidate/lib/validators";
    import { setTimeout } from "timers";
    import ButtonSpinner from "../components/SpinnerButton.vue";
    import requestModule from "../common/utils/RequsetModule";
    export default {
        name: "login-component",
        components: {
            ButtonSpinner
        },
        data: function () {
            return {
                PRODUCT_NAME: _VALUES.PRODUCT_NAME,
                COMPANY_NAME: _VALUES.COMPANY_NAME,
                USERS: _VALUES.USERS,
                login: {
                    username: "",
                    password: ""
                },
                isLoading: false,
                status: "",
                hasError: false
            };
        },
        props: {
            login: {
                username: String,
                password: String
            },
            indexUrl: String,
            loginUrl: String,
            guestLoginUrl: String,
            registerUrl: String,
            loginConfirm: String
        },
        validations: {
            login: {
                username: { required, email },
                password: {
                    required,
                    minLength: minLength(_VALUES.PASSWORD_LENGTH_MIN),
                    maxLength: maxLength(_VALUES.PASSWORD_LENGTH_MAX)
                }
            }
        },
        methods: {

            openRegister() {
                window.location.href = this.registerUrl;
            },
            loginGuest() {
                window.location.href = this.guestLoginUrl;
            },
            serviceLogin() {
                this.$v.$reset();
                this.$v.login.$touch();
                if (this.$v.login.$error) return;

                var vm = this;
                this.isLoading = true;
                requestModule()
                    .post(LOGIN, {
                        email: vm.login.username,
                        password: vm.login.password
                    })
                    .then(function (res) {
                        vm.isLoading = false;
                        vm.status = true;
                        if (!res.data) {
                            return;
                        }
                        var userObj = JSON.stringify(res.data.thisuser);

                        vm.setCookie("token", res.data.token, 1);
                        vm.setCookie("currentUser", userObj, 1);
                        localStorage.setItem("currentUser", userObj);

                        vm.authorize(res.data);
                    })
                    .catch(function (err) {
                        if (err.response.status === 403) {
                            vm.hasError = true;
                            setTimeout(function () {
                                vm.hasError = false;
                            }, 1500);
                        }
                        vm.isLoading = false;
                        vm.status = "";
                        console.log(err);
                    });
            },
            authorize(data) {
                var locf = this.loginConfirm;
                var index = this.indexUrl;
                requestModule()
                    .post(locf, data)
                    .then(function (res) {
                        window.location.href = index;
                    });
            },
            setCookie(cname, cvalue, exdays) {
                var d = new Date();
                d.setTime(d.getTime() + exdays * 24 * 60 * 60 * 1000);
                $cookies.config(d.toUTCString(), "/");
                $cookies.set(cname, cvalue);
            }
        },
        mounted() {
            let script = document.createElement("script");
            script.setAttribute("src", "https://apis.google.com/js/platform.js");
            document.head.appendChild(script);
        },
        beforeMount() {
            var vm = this;
            if ($cookies.get("token")) {
                vm.setCookie("token", null, -1);
                vm.setCookie("currentUser", null, -1);
                window.location.href = this.indexUrl;
            }
        }
    };
</script>