export const formBuilderJsonToLimsJson = function(input) {
  let formElements = JSON.parse(JSON.stringify(input));
  let fields = new Array();
  try {
    for (var i = 0; i < formElements.length; i++) {
      let element = formElements[i];
      let values = "";
      switch(element.type) {
        case "checkbox-field":
        case "radio-field":
        case "dropdown-field":
          values = element.options.type_items.join();
          break;
      }

      let tmp = {
        "name": element.options.type_label,
        "sequenceNo": i,
        "key": element.options.type_id,
        "field": element.type,
        "fieldType": element.type,
        "mandatory": element.options.type_required,
        "dependentOn": "",
        "dependentValue": "",
        "selection": "",
        "values": values
      }
      fields.push(tmp);
    }
    return fields;
  } catch(err) {
    alert("JSON Error. Abort."+err);
    return new Array();
  }
}
export const limsJsonToFormBuilderJson = function(fields) {
  let formBuilderArray = new Array();
  if(!fields){
    return new Array();
  }
  try {
    fields.forEach(field => {
      let jsonObject = new Object();
      jsonObject.field_id = field.key,
      jsonObject.type = field.fieldType,
      jsonObject.isActive = false,
      jsonObject.field_value = "",
      jsonObject.options = {
        type_id: field.key,
        type_name: field.name,
        type_placeholder: "",
        type_label: field.name,
        type_required: false,
        type_required_message: null,
        type_help_text: "This is help text.",
        type_is_number: false,
        type_number_range: "",
        section: null,
        position: "default",
        type_tooltip: "",
        min_length: "",
        max_length: "",
        regex: "",
        default_value: null,
        conditional_logic: false,
        precondition_field: null,
        expression: "",
        condition_value: null,
        action: null,
        type_items: []
      }

      if(field.fieldType === "checkbox-field" || field.fieldType === "radio-field" || field.fieldType === "dropdown-field") {
        jsonObject.options.type_items = field.values.split(',');
      }

      formBuilderArray.push(jsonObject);
    });
    return formBuilderArray;
  } catch(err) {
    alert("JSON Error. Abort."+err);
    return new Array();
  }
}