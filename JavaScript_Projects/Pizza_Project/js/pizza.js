
function getReceipt () { //function to print the receipt when a pizza is ordered
    var text1 = "<h3>Your Order:</h3>"; 
    var runningTotal = 0;
    var sizeTotal = 0;
    var sizeArray = document.getElementsByClassName("size"); //creates a one element array of the selected size
    for (var i = 0; i < sizeArray.length; i++) { //iterates once  to add pizza size to receipt
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value; //sets the selected size as a variable
            text1 = text1 + "<h2>" + selectedSize + "</h2>" + "<br>";
        }
    }

    if (selectedSize === "Personal Pizza") { //prices for pizza sizes
        sizeTotal = 6;
    } else if (selectedSize === "Small Pizza") {
        sizeTotal = 8;
    } else if (selectedSize === "Medium Pizza") {
        sizeTotal = 10;
    } else if (selectedSize === "Large Pizza") {
        sizeTotal = 14;
    } else if (selectedSize === "Party Size Pizza") {
        sizeTotal = 16;
    }

    runningTotal = sizeTotal;  //adds size price to total price
    console.log(selectedSize + " = $" + sizeTotal + ".00"); //logs this information in console
    console.log("size text1: " + text1);
    console.log("subtotal: $" + runningTotal + ".00");
    getTopping (runningTotal, text1); //sends current total and receipt to getTopping function
};

function getTopping(runningTotal, text1) { //function to add prices of selected toppings and print final receipt
    var toppingTotal = 0; //needed for price
    var selectedTopping = []; //array to include all checked toppings
    var toppingArray = document.getElementsByClassName("toppings"); //Gets an array of all toppings
    for (var j = 0; j < toppingArray.length; j++) { // iterates through the toppings
        if (toppingArray[j].checked) { //checking which ones are checked
            selectedTopping.push(toppingArray[j].value); //and adding them to the selected topping array.
            console.log("selected toppings: ("+toppingArray[j].value  + ")"); //logs toppings in console
            text1 = text1 + toppingArray[j].value + "<br>"; // writes selected topping to the receipt
        }
    }

    var toppingCount = selectedTopping.length; //counts the number of toppings
    if (toppingCount > 1) {
        toppingTotal = (toppingCount - 1); //1 FREE TOPPING!!!!!!
    } else {
        toppingTotal = 0;
    }

    runningTotal = (runningTotal + toppingTotal); //Each topping is a dollar
    console.log ("total selected toppings: " + toppingCount); //more console logging
    console.log (toppingCount + " topping - 1 free topping = " + "$" + toppingTotal + ".00");
    console.log("topping text1: " + text1);
    console.log("Purchase Total: " + "$" + runningTotal + ".00");
    document.getElementById("showText").innerHTML=text1; //actually displays receipt
    document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$" + runningTotal + ".00" + "</strong></h3>"; //displays total
};