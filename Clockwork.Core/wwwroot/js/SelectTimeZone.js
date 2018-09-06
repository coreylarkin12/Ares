

function UserAction() {
    $.get("http://localhost:58148/api/selecttimezone").done(function (data) {
        $.each(data, function (i, item) {
            $('#mySelect').append($('<option>', {
                value: item.BaseUtcOffset,
                text: item.DisplayName
            }));
        });
    });
}

function ConvertTime() {
    var selectedTimeZone = $('#mySelect').find(":selected").val();
    var name = $('#mySelect').find(":selected").text();

    selectedTimeZone.toString();

    $('#converted').append('<li>  ' + selectedTimeZone + '  ---  ' + name + '</li>')
}
