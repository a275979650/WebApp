function ClickRemoveChangeCode() {
    var code = $("#captcha_img").attr("src");
    $("#captcha_img").attr("src", code + "1");
}