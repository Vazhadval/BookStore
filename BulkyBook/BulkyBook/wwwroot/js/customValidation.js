
function ValidateSummaryPageInputs() {
    return document.getElementById("OrderHeader_Name").innerText != null &&
        document.getElementById("OrderHeader_PhoneNumber").innerText != null &&
        document.getElementById("OrderHeader_StreetAddress").innerText != null &&
        document.getElementById("OrderHeader_City").innerText != null &&
        document.getElementById("OrderHeader_State").innerText != null &&
        document.getElementById("OrderHeader_PostalCode").innerText != null;
}