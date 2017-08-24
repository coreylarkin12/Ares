/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    $("#SameShipping").click(function () {

        $("#ShippingAddress1").val($("#BillingAddress1").val());
        $("#ShippingAddress2").val($("#BillingAddress2").val());
        $("#ShippingCity").val($("#BillingCity").val());
        $("#ShippingState").val($("#BillingState").val());
        $("#ShippingPostalCode").val($("#BillingPostalCode").val());

    });

    $("input[name=ShippingType]").click(function () {

        $("#ShippingAddress1").val($("#BillingAddress1").val());
        $("#ShippingAddress2").val($("#BillingAddress2").val());
        $("#ShippingCity").val($("#BillingCity").val());
        $("#ShippingState").val($("#BillingState").val());
        $("#ShippingPostalCode").val($("#BillingPostalCode").val());

    });


});




