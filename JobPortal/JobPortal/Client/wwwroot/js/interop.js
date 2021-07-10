
function candidate() {
    document.getElementById("companyloginform").style.display = "none";
    
    document.getElementById("candidateloginform").style.display = "block";
}
function company() {

    document.getElementById("companyloginform").style.display = "block";

    document.getElementById("candidateloginform").style.display = "none";
}
function candidateSignUpShow() {
    document.querySelector("form.login").style.marginLeft = "0%";
    document.querySelector(".title-text .login").style.marginLeft = "0%";
}
function companySignUpShow() {
    document.querySelector("form.login").style.marginLeft = "-50%";
    document.querySelector(".title-text .login").style.marginLeft = "-50%";
}
$(window).scroll(function scroll() {
    $('nav').toggleClass('scrolled', $(this).scrollTop() > 50);
});