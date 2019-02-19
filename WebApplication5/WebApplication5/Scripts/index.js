$(document).ready(function () {
    $("#button").on("click", function () {
        $.ajax({
            type: "POST",
            url: "WebForm.aspx/GetData",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({id : "24"}),
            dataType: "json",
            success: function (result) {
                alert('ok' + JSON.stringify(result));
            },
            error: function (result) {
                alert('error');
            }
        });
    });
}); 
