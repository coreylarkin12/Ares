
function UserAction() {
    $.get("http://localhost:58148/api/currenttime").done(function (data) {
        $('#clientIp').html(data.ClientIp);
        $('#currentTimeQueryId').html(data.CurrentTimeQueryId);
        $('#time').html(data.Time);
        $('#utcTime').html(data.UTCTime);

        var row = '<tr> <td>' + data.ClientIp + '</td> <td> ' + data.CurrentTimeQueryId + ' </td><td>' + data.Time + '</td><td>' + data.UTCTime + '</td></tr>'
        $(row).insertAfter("#getAllTable tr:first")
    });
}

function formatItem(item) {
    return '<td>' + item.ClientIp + '</td> <td> ' + item.CurrentTimeQueryId + ' </td><td>' + item.Time + '</td><td>' + item.UTCTime + '</td>';
}

function GetAll() {
    $.get("http://localhost:58148/api/getall").done(function (data) {
        $.each(data, function (key, item) {
            $('<tr>', { html: formatItem(item) }).appendTo($("#getAllTable"));
            $('#show').attr("disabled", true)
        })
    });

}