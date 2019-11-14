
const PASSWORD_LENGTH_MIN = 4;
const PASSWORD_LENGTH_MAX = 20;
export const _VALUES = {
    PRODUCT_NAME: "ERNESTOCO",
    COMPANY_NAME: "Creative Webs HQ",
    COPYRIGHT: "©  ERNESTOCO. All rights reserved.",
    USERS: ["Admin", "User", "Guest"],
    PASSWORD_LENGTH_MIN,
    PASSWORD_LENGTH_MAX,
    PASSWORD_VALID_REGEX: `^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{${PASSWORD_LENGTH_MIN},${PASSWORD_LENGTH_MAX}}$`,
    VALIDATION_REQUIRED_TEXT: "This field is required.",
    VALIDATION_DUPLICATE_TEXT: "Value already exists.",
    VALIDATION_ALPHABETIC_ONLY: "This field can only contain alphabetic characters.",
    VALIDATION_NUMBERS_ONLY: "This field can only contain numbers.",
    VALIDATION_EMAIL_FIELD: "Enter a valid email address.",
    VALIDATION_TNT_FIELD: "Enter a valid turn arond time.",
    VALIDATION_LETTERS_ONLY_INITIALS: "Initials can only be letters.",
    VALIDATION_DOB: " Invalid DOB.",
    VALIDATION_EXPDATE: " Invalid Expiry Date.",
    VALIDATION_ICPASSPORT: " Invalid IC/Passport. Should be longer than 3.",
    VALIDATION_CONTACT: " Invalid Contact.",
    DATE_TIME_DISPLAY_FORMAT: "DD MMM, YYYY HH:mm",
    DATE_DISPLAY_FORMAT: "DD MMM, YYYY",
    DEFAULT_COUNTRY: "USA",
    COUNTRIES: ["Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "People 's Republic of China", "Republic of China", "Christmas Island", "Cocos(Keeling) Islands", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "French Polynesia", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea - Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "North Korea", "South Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Nagorno - Karabakh", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Turkish Republic of Northern Cyprus", "Northern Mariana", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Islands", "Poland", "Portugal", "Puerto Rico", "Qatar", "Romania", "Russia", "Rwanda", "Saint Barthelemy", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "Somaliland", "South Africa", "South Ossetia", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor - Leste", "Togo", "Tokelau", "Tonga", "Transnistria Pridnestrovie", "Trinidad and Tobago", "Tristan da Cunha", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "British Virgin Islands", "Isle of Man", "US Virgin Islands", "Wallis and Futuna", "Western Sahara", "Yemen", "Zambia", "Zimbabwe"],
};
