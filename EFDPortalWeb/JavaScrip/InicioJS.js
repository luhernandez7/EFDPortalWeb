function GetProject() {
    $.ajax({
        type: "GET",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        url: "../MasterPages/Inicio.aspx/GetProject",
        success: function (msg) {
            window.location.href = "../MasterPages/inicio.aspx";
        },
        error: function (request, message, error) {
            handleException(request, message, error);
        }
    });
}