/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {
    $("#form0").validate({

        debug: true,
        rules: {

            emailAddr: {
                email: true,            //require this field to only accept email                
                required: {
                    depends: function (element) {
                        return $("#EmailAddress").is(":checked");
                    }
                },

            },
            password: {
                required: true,         //requires password field
                minlength: 8,           //requires at least 8 characters
                strongpassword: true    //uses custom validator for strong password
            },
            verifyPassword: {
                equalTo: "#Password"    //uses the CSS selector to match value of the field
            },
        },

    });


    $("#errorSummary").validate({

        debug: true,
        rules: {

            bAddress1: {
                required: {
                    depends: function (element) {
                        return $("#BillingAddress1").is(":checked");
                    }
                }
            },
            bAddress2: {
                required: false,

            },
            bState: {
                required: {
                    required: {
                        depends: function (element) {
                            return $("#BillingState").is(":checked");
                        }
                    }
                }
            },
            bCity: {
                required: {
                    depends: function (element) {
                        return $("#BillingCity").is(":checked");
                    }
                }//using an additional jquery validation method
            },
        },
    });
});

//Create a custom validation rule that only permits email addresses that end with @techelevator.com
//https://jqueryvalidation.org/jQuery.validator.addMethod
//$.validator.addMethod("techElevatorEmail", function (value, index) {
//    return value.toLowerCase().endsWith("@techelevator.com");  // it would be safer to consider a regex here. 
//}, "Please enter a techelevator.com email");

$.validator.addMethod("strongpassword", function (value, index) {
    return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
}, "Please enter a strong password (one capital, one lower case, and one number");

   
});


