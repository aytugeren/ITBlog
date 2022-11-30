let userName = document.getElementById("register-form-username");
let name = document.getElementById("register-form-name");
let secondname = document.getElementById("register-form-secondname");
let lastname = document.getElementById("register-form-lastname");
let birthday = document.getElementById("register-form-birthday");
let email = document.getElementById("register-form-email");
let password = document.getElementById("register-form-password");
let repassword = document.getElementById("register-form-repassword");
let forgotButton = document.getElementById("forgotButton");
let forgotEmail = document.getElementById("forgotEmail");
let submitButton = document.getElementById("submit");
let errorMessage = document.getElementById("errorMessage");
let errorMessagePassword = document.getElementById("errorMessagePassword");
let loading = document.getElementById("loading");
let welcomeBox = document.getElementById("welcomeBox");
let welcomeMessage = document.getElementById("welcomeMessage");
let messageForPassword = document.getElementById("messageForPassword");
let bigCharachterMessage = document.getElementById("BigCharachterMessage");
let smallCharacterMessage = document.getElementById("SmallCharacterMessage");
let lengthCharacterMessage = document.getElementById("LengthCharacterMessage");
let specialCharacterMessage = document.getElementById("SpecialCharacterMessage");
let spaceCharacterMessage = document.getElementById("SpaceCharacterMessage");
let numericCharacterMessage = document.getElementById("NumericCharacterMessage");
let errorMessageRePassword = document.getElementById("errorMessageRePassword");
let infoMessageSubmit = document.getElementById("infoMessageSubmit");
let loginInfoMessageSubmit = document.getElementById("loginInfoMessageSubmit");
let successAlert = document.getElementById("successAlert");
let infoAlert = document.getElementById("infoAlert");
let errorAlert = document.getElementById("errorAlert");
let warningAlert = document.getElementById("warningAlert");

const delay = ms => new Promise(res => setTimeout(res, ms));
let baseUrl = window.location.origin;
let port = window.location.port;
forgotButton.addEventListener("click", function () {
    console.log("asdfsdf");
});
userName.addEventListener("input", function () {
    var text = userName.value;
    welcomeBox.setAttribute("style", "display:none;");

    if (isTextIncludeWrongCharacter(text)) {
        errorMessage.removeAttribute("style");
        errorMessage.innerHTML = "\n Dikkat Yasaklı Karakter Giriyorsunuz!\n ";
        userName.value = text.replace(/[!\.+_!@#$%^&*()\t\r\n\[\][/]/g, "");
    }
    else {
        errorMessage.setAttribute("style", "display:none;");
    }

    if (text.length >= 30) {
        errorMessage.removeAttribute("style");
        errorMessage.innerHTML = "\n                        Dikkat 30 Karakteri Geçemezsiniz!\n                    "
        userName.value = text.substring(0, text.length - 1);
    }
})

userName.addEventListener("blur", async function () {
    if (userName.value.length > 0) {
        loading.removeAttribute("style");
        var resultOfUserName = await getUserIsExist("User", "GetUserNameIsExist", "userName=" + userName.value);
        if (resultOfUserName) {
            welcomeBox.removeAttribute("class");
            welcomeBox.setAttribute("class", "style-msg errormsg")
            welcomeMessage.innerHTML = "Kullanıcı Var! Başka bir kullanıcı adı deneyin!"
            loading.setAttribute("style", "display:none;");
            welcomeBox.removeAttribute("style");
        }
        else {
            welcomeBox.removeAttribute("class");
            welcomeBox.setAttribute("class", "style-msg successmsg")
            welcomeMessage.innerHTML = "<strong>" + userName.value + "</strong> Aramıza hoşgeldin. <i class='bi-emoji-laughing'></i>"
            loading.setAttribute("style", "display:none;");
            welcomeBox.removeAttribute("style");
        }
    }
})

password.addEventListener("input", function () {
    checkTheText(password.value);
})

repassword.addEventListener("input", function () {
    var result = isTwoTextIsSame(password.value, repassword.value);
    if (result) {
        errorMessageRePassword.setAttribute("style", "display:none");
    }
    else {
        errorMessageRePassword.removeAttribute("style");
        errorMessageRePassword.innerHTML = "<strong>Dikkat</strong> Parolalar Uyuşmuyor!"
    }
})

submitButton.addEventListener("click", async function () {
    submitButton.setAttribute("style", "display:none;")
    loadingSubmit.removeAttribute("style");
    await delay(1000);
    infoMessageSubmit.innerHTML = "Kullanıcı Adı Kontrol Ediliyor!";
    if (userName.value != "" && userName.value != null) {
        var resultOfUserName = await getUserIsExist("User", "GetUserNameIsExist", "userName=" + userName.value);
        if (resultOfUserName === false) {
            infoMessageSubmit.innerHTML = "Email Kontrol Ediliyor!";
            if (email.value != "" && email.value != null) {
                var resultOfEmail = await getUserIsExist("User", "GetEmailIsExists", "email=" + email.value);
                if (resultOfEmail === false) {
                    infoMessageSubmit.innerHTML = "Parolalar Kontrol Ediliyor!";
                    var resultOfEmail = isTwoTextIsSame(password.value, repassword.value);
                    infoMessageSubmit.innerHTML = "İsim Alanı Kontrol Ediliyor!";
                    await delay(200);
                    if (name.value != "" && name.value != null) {
                        infoMessageSubmit.innerHTML = "Soyisim Alanı Kontrol Ediliyor!";
                        if (lastname.value != "" && lastname.value != null) {
                            infoMessageSubmit.innerHTML = "Parolalar Kontrol Ediliyor!";
                            if (isTwoTextIsSame(password.value, repassword.value)) {
                                if (checkTheText(password.value)) {
                                    infoMessageSubmit.innerHTML = "Herşey Tamam! Kullanıcıyı Oluşturuyoruz..";
                                    let postObj = {
                                        UserName: userName.value,
                                        FirstName: name.value,
                                        SecondName: secondname.value,
                                        LastName: lastname.value,
                                        Birthday: birthday.value,
                                        Email: email.value,
                                        Password: password.value,
                                    }
                                    var result = await submitTheUser("User", "SubmitForUserName", postObj);
                                    if (result === true) {
                                        successAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kullanıcı Başarılı Bir Şekilde Oluşturuldu!");
                                        successAlert.click();
                                        submitButton.removeAttribute("style")
                                        loadingSubmit.setAttribute("style", "display:none;")
                                        window.location.replace(baseUrl + "/User/SignUp?email=" + email.value + "&isFromRegister=" + password.value);
                                    } else {
                                        errorAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kullanıcı Oluşturulurken Hata Meydana Geldi!");
                                        errorAlert.click();
                                        submitButton.removeAttribute("style")
                                        loadingSubmit.setAttribute("style", "display:none;")
                                    }
                                }
                                else {
                                    warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Parola Kurallara Uymuyor!");
                                    warningAlert.click();
                                    submitButton.removeAttribute("style")
                                    loadingSubmit.setAttribute("style", "display:none;")
                                }
                            }
                            else {
                                warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Parolalar Uyuşmuyor!");
                                warningAlert.click();
                                submitButton.removeAttribute("style")
                                loadingSubmit.setAttribute("style", "display:none;")
                            }
                        }
                        else {
                            warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Soyisim Alanı Boş!");
                            warningAlert.click();
                            submitButton.removeAttribute("style")
                            loadingSubmit.setAttribute("style", "display:none;")
                        }
                    } else {
                        warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Ad Alanı Boş!");
                        warningAlert.click();
                        submitButton.removeAttribute("style")
                        loadingSubmit.setAttribute("style", "display:none;")
                    }
                }
                else {
                    warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Mail Zaten Var!");
                    warningAlert.click();
                    submitButton.removeAttribute("style")
                    loadingSubmit.setAttribute("style", "display:none;")
                }
            }
            else {
                warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Email Alanı Boş!");
                warningAlert.click();
                submitButton.removeAttribute("style")
                loadingSubmit.setAttribute("style", "display:none;")
            }
        }
        else {
            submitButton.removeAttribute("style")
            loadingSubmit.setAttribute("style", "display:none;")
            errorAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kullanıcı Zaten Var!");
            errorAlert.click();
        }
    }
    else {
        warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kullanıcı Adı Alanı Boş!");
        warningAlert.click();
        submitButton.removeAttribute("style")
        loadingSubmit.setAttribute("style", "display:none;")
    }
})

async function getUserIsExist(controller, method, parametre) {
    let url = baseUrl + "/" + controller + "/" + method + "?" + parametre;
    const response = await fetch(url, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    });
    const jsonData = response.json();

    return jsonData;
}

async function submitTheUser(controller, method, parametre) {
    console.log(parametre);
    let url = baseUrl + "/" + controller + "/" + method;
    const response = await fetch(url, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(parametre)
    });
    const jsonData = response.json();

    return jsonData;
}

function isTextIncludeWrongCharacter(text) {
    var result = text.match(/[!\.+_!@#$%^&*()\t\r\n\[\][/]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTextIncludSpaceCharacter(text) {
    var result = text.match(/[\t\n\v\f\r \u00a0\u2000\u2001\u2002\u2003\u2004\u2005\u2006\u2007\u2008\u2009\u200a\u200b\u2028\u2029\u3000]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTextIncludeSpecialCharacter(text) {
    var result = text.match(/[!\.+_!@#$%^&*()\[\][/]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTextIncludeBigCharacter(text) {
    var result = text.match(/[A-Z]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTextIncludeNumericCharacter(text) {
    var result = text.match(/[0-9]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTextIncludeSmallCharacter(text) {
    var result = text.match(/[a-z]/g);

    if (result != null) {
        return true;
    }
    else {
        return false;
    }
}

function isTwoTextIsSame(text1, text2) {
    if (text1 === text2) {
        return true;
    }
    else {
        return false;
    }
}

function checkTheText(text, isSubmit) {
    var isTextIncludeWrong = isTextIncludSpaceCharacter(text);
    var isTextIncludeSpecial = isTextIncludeSpecialCharacter(text);
    var isTextIncludeBig = isTextIncludeBigCharacter(text);
    var isTextIncludeSmall = isTextIncludeSmallCharacter(text);
    var isTextIncludeNumeric = isTextIncludeNumericCharacter(text);
    var result = false;
    if (isTextIncludeWrong) {
        password.value = text.replace(/[!\.+_!@#$%^&*()\t\r\n\[\][/]/g, "");
        spaceCharacterMessage.setAttribute("style", "color:red;")
        result = false;
    }
    else {
        spaceCharacterMessage.setAttribute("style", "color:#BADA55;")
        result = true;
    }
    if (isTextIncludeSpecial) {
        specialCharacterMessage.setAttribute("style", "display:none;");
        result = true;
    }
    else {
        specialCharacterMessage.removeAttribute("style");
        result = false;
    }

    if (isTextIncludeBig) {
        bigCharachterMessage.setAttribute("style", "display:none;");
        result = true;
    }
    else {
        bigCharachterMessage.removeAttribute("style");
        result = false;
    }
    if (isTextIncludeSmall) {
        smallCharacterMessage.setAttribute("style", "display:none;");
        result = true;
    }
    else {
        smallCharacterMessage.removeAttribute("style");
        result = false;
    }
    if (isTextIncludeNumeric) {
        numericCharacterMessage.setAttribute("style", "display:none;");
        result = true;
    }
    else {
        numericCharacterMessage.removeAttribute("style");
        result = false;
    }
    if (text.length > 10) {
        lengthCharacterMessage.setAttribute("style", "color:#BADA55;");
        result = true;
    }
    else {
        lengthCharacterMessage.setAttribute("style", "color:red;")
        result = false;
    }

    if (text.length === 0) {
        lengthCharacterMessage.removeAttribute("style");
        spaceCharacterMessage.removeAttribute("style");
        result = false;
    }

    return result;
}

