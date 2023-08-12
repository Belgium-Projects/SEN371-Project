document.addEventListener("DOMContentLoaded", function() {
    const saveButton = document.getElementById("save-details");
    const firstnameInput = document.getElementById("firstname");
    const surnameInput = document.getElementById("surname");
    const phoneInput = document.getElementById("phone");
    const dobInput = document.getElementById("dob");
    const addressInput = document.getElementById("address");
    const zipInput = document.getElementById("zip");
    const businessNameInput = document.getElementById("business-name");
  
    saveButton.addEventListener("click", function() {
      const formData = {
        firstname: firstnameInput.value,
        surname: surnameInput.value,
        phone: phoneInput.value,
        dob: dobInput.value,
        address: addressInput.value,
        zip: zipInput.value,
        businessName: businessNameInput.value
      };
  
      // Here you would typically send the formData to the server for processing and storage.
      // You can use fetch() or an AJAX library for this purpose.
  
      // For demonstration, let's show an alert with the submitted data.
      alert("Details saved!\n" + JSON.stringify(formData, null, 2));
    });
  });
  