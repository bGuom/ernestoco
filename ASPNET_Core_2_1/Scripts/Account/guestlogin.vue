<template>
    <div class="gray-bg">

        <div class="passwordBox animated fadeInDown">
            <div class="row">

                <div class="col-md-12">
                    <div class="ibox-content">

                        <h2 class="font-bold">{{PRODUCT_NAME}} Guest Login</h2>

                        <p>
                            Enter your display name and you will be logged in.
                        </p>

                        <div class="row">

                            <div class="col-lg-12">
                                <form class="m-t" role="form" >
                                    <div class="form-group">
                                        <input type="text" class="form-control" placeholder="Display Name" v-model="displayName" required="">
                                    </div>

                                    <button-spinner type="submit"
                                                    spinnerClass="btn btn-primary block full-width m-b"
                                                    @click.native="serviceLogin()"
                                                    v-bind="{isLoading, status}"
                                                    :disabled="isLoading">Login  as Guest</button-spinner>
                                </form>
                            </div>
                        </div>
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

</template>
<script>
    import { GUEST_LOGIN } from "../common/constants/url";
    import { _VALUES } from "../common/constants/values";
    import { setTimeout } from "timers";
    import ButtonSpinner from "../components/SpinnerButton.vue";
    import requestModule from "../common/utils/RequsetModule";
    import {
      required,
    } from "vuelidate/lib/validators";
    export default {
        name: "guest-login-component",
        components: {
            ButtonSpinner
        },
        data: function () {
            return {
                PRODUCT_NAME: _VALUES.PRODUCT_NAME,
                COMPANY_NAME: _VALUES.COMPANY_NAME,
                USERS: _VALUES.USERS,
                displayName:"",
                isLoading: false,
                status: "",
                hasError: false
            };
        },
        props: {
            indexUrl: String,
            loginUrl: String,
            loginConfirm: String
        },
        validations: {
            displayName: { required }
        },
        methods: {

            
            serviceLogin() {
                this.$v.$reset();
                this.$v.displayName.$touch();
                if (this.$v.displayName.$error) return;

                var vm = this;
                this.isLoading = true;
                requestModule()
                    .post(GUEST_LOGIN, {
                        displayName: vm.displayName
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