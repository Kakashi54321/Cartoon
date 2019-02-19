$(document).ready(function () {
    $("#button").on("click", function () {
        $.ajax({
            type: "GET",
            url: "JavaScript.aspx/GetData",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result) {
                alert('ok');
            },
            error: function (result) {
                alert('error');
            }
        });
    });
}); 
