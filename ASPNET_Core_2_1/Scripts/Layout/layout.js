import "../general/styles/clr-icons.min.css";
import "../general/styles/clr-ui.min.css";
import "../assets/scss/style.scss";
import "../general/styles/v-calendar.min.css";
import "../general/styles/vue-multiselect.min.css";
import "../../../node_modules/ag-grid-community/dist/styles/ag-grid.css";
import "../../../node_modules/ag-grid-community/dist/styles/ag-theme-material.css";
import "../../../node_modules/@fortawesome/fontawesome-free/scss/fontawesome.scss";
import "../../../node_modules/@fortawesome/fontawesome-free/scss/solid.scss";

import { LOGIN, GOOGLE_LOGIN } from "../general/constants/url";

if (document.getElementById('account_url') !== null)
    document.getElementById('account_url').value = LOGIN;

if (document.getElementById('gtoken_login') !== null)
    document.getElementById('gtoken_login').value = GOOGLE_LOGIN;