
document.addEventListener("DOMContentLoaded", function() {
  const saveButton = document.getElementById("save-details");

  saveButton.addEventListener("click", function() {
    // Collect client details from the form
    const firstName = document.getElementById("firstname").value;
    const surname = document.getElementById("surname").value;
    const email = document.getElementById("email").value;
    const phone = document.getElementById("phone").value;
    const dob = document.getElementById("dob").value;
    const address = document.getElementById("address").value;
    const zip = document.getElementById("zip").value;
    const businessName = document.getElementById("business-name").value;

    // Create an object to store the client details
    const clientDetails = {
      firstName: firstName,
      surname: surname,
      email: email,
      phone: phone,
      dob: dob,
      address: address,
      zip: zip,
      businessName: businessName
    };

    // Store the client details in localStorage
    localStorage.setItem("clientDetails", JSON.stringify(clientDetails));
    //alert("Details saved!\n" + JSON.stringify(formData, null, 2));
    // Open the chatbot webpage
    window.location.href = "chatbot.html";
  });
});

  