let subButton = document.getElementById("GetBeSubs");
let subEmail = document.getElementById("subsEmail");
let successAlert = document.getElementById("successAlert");
let infoAlert = document.getElementById("infoAlert");
let errorAlert = document.getElementById("errorAlert");
let warningAlert = document.getElementById("warningAlert");

let baseUrl = window.location.origin + "/";
let port = window.location.port;

subButton.addEventListener("click", async function () {

    if (subEmail.value.includes("@")) {
        let controllerName = "Home";
        let methodName = "GetSubsBox";
        let url = baseUrl + controllerName + "/" + methodName + "?email=" + subEmail.value;
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        });
        const content = await response.json();
        if (content === "EntityStillCreated") {
            successAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kişi Başarıyla Oluşturulmuş! Onay mailini inceleyip onaylayınız!");
            successAlert.click();
        }
        else if (content == "EntityCreated") {
            successAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Kişi Başarıyla Oluşturulmuş! Onay mailini inceleyip onaylayınız!");
            successAlert.click();
        }
        else if (content == "EntityError") {
                errorAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Hata Oluştu!");
                errorAlert.click();
        }
        else {
            warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Lütfen geçerli bir veri giriniz!");
            warningAlert.click();
        }
    }
    else {
        warningAlert.setAttribute("data-notify-msg", "<i class='icon-ok-sign me-1'></i> Lütfen geçerli bir veri giriniz!");
        warningAlert.click();
    }



})

