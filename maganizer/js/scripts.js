$(function () {
    $(".btn").click(function () {
        $(".signup-inactive").toggleClass("signup-active");
        $(".signin-active").toggleClass("signin-inactive");
        $(".form-signin").toggleClass("form-signin-hidden");
        $(".form-signup-hidden").toggleClass("form-signup")
        $(".wrap-login100").toggleClass("long-wrap-login100")
    });
});

$(function () {
    $("#btnSignUp").click(function () {
        var password = $("#password").val();
        var confirmPassword = $("#confirmPassword").val();
        if (password != confirmPassword) {
            alert("Passwords do not match.");
            return false;
        }
        return true;
    });
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#changeAvatar').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#fileinput").change(function () {
    readURL(this);
});

