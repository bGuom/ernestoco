export const IS_PRODUCTION = false;
export const isPaginationEnabled = true;
export const API_HOSTNAMES = {
    dev: document.getElementById("auth_api_url").value, 
    uat: document.getElementById("auth_api_url").value,  
    prod: document.getElementById("auth_api_url").value, 
};
export const SELECTED_HOST = "dev";
const API_HOSTNAME = `${API_HOSTNAMES[SELECTED_HOST]}/api`;
export const urlPostFix = isPaginationEnabled ? "?Start=0&Count=1000" : "";

export const REGISTER = `${API_HOSTNAME}/Auth/Register`;
export const LOGIN = `${API_HOSTNAME}/Auth/GetToken`;
export const GUEST_LOGIN = `${API_HOSTNAME}/Auth/GuestLogin`;
export const GOOGLE_LOGIN = `${API_HOSTNAME}/Auth/gtoken`;
