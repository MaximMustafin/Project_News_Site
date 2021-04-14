$(function () {
    $(".btn").click(function () {
        $(".signup-inactive").toggleClass("signup-active");
        $(".signin-active").toggleClass("signin-inactive");
        $(".form-signin").toggleClass("form-signin-hidden");
        $(".form-signup-hidden").toggleClass("form-signup")
        $(".wrap-login100").toggleClass("long-wrap-login100")
    });
});




