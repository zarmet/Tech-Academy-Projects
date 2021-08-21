function validateForm() {
    let x = document.forms["myForm"]["firstName"].value;
    let y= document.forms["myForm"]["lastName"].value;
    let z= document.forms["myForm"]["favMovie"].value;
    if (x == "" || y == "" || z == "") {
      alert("All fields must be filled");
      return false;
    }
  }