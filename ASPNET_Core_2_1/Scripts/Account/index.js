import Vue from 'vue';
import Vuelidate from "vuelidate";
import VueCookies from "vue-cookies";
import LoginComponent from './login.vue';
import GuestLoginComponent from './guestlogin.vue';
import RegisterComponent from './register.vue';
import ForgotPasswordComponent from './forgotpassword.vue';

Vue.use(Vuelidate);
Vue.use(VueCookies);

new Vue({
    el: "#app",
    components: {
        LoginComponent,
        GuestLoginComponent,
        RegisterComponent,
        ForgotPasswordComponent,
    },
    data() {
    },
    methods: {
    }
})