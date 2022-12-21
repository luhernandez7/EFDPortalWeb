function Login(Usuario, Password) {
    $.ajax({
        type: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        url: "../MasterPages/login.aspx/Login",
        data: '{ Usuario: "' + document.getElementById(Usuario).value + '", Password: "' + document.getElementById(Password).value + '" }',
        success: function (msg) {
            window.location.href = "../MasterPages/inicio.aspx";
        },
        error: function (request, message, error) {
            handleException(request, message, error);
        }
    });
}

function handleException(request, message, error) {
    var msg = "";
    switch (request.status) {
        case 500:
            // Display error message thrown from the server
            msg = request.responseJSON.Message;
            break;

        default:
            msg = "Status: " + request.status;
            msg += "\n" + "Error Message: " +
                request.statusText;
            break;
    }
    $('#msg').html(msg);
    //swal({ title: "Algo salió mal", text: "" + msg + "", type: "error" });
}
