import moment from "moment";
import { LIMS_CONSTANTS } from "../constants/constant";

export const getFormattedDate = function(inputDate) {
    let handledDate = (inputDate) ? new Date(inputDate) : new Date();
    return moment(handledDate).format(LIMS_CONSTANTS.DATE_TIME_DISPLAY_FORMAT);
}