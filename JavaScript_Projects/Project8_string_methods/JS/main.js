function theHobbit () { //function using concat, slice, toPrecision, and toString
    var str1= "In a hole in the ground, "; //some lovely strings to concatenate
    var str2= "there lived a hobbit. ";
    var str3= "Not a nasty, dirty, wet hole filled ";
    var str4= "with the ends of worms and an oozy smell, ";
    var str5= "nor, yet a dry, bare, sandy hole with ";
    var str6= "nothing in it to sit down on or to eat: ";
    var str7= "it was a hobbit-hole, and that means comfort...";
    var share=871E9/13 //a number to turn into a string
    document.getElementById("concatenate").innerHTML=str1.concat(str2, str3, str4, str5, str6, str7); //concatenating the strings into a sentence
    document.getElementById("slice").innerHTML="THE "+str2.slice(13, 20).toUpperCase() //slicing out hobbit to make a title
    document.getElementById("string_precision").innerHTML="Bilbo's portion of the treasure: $"+share.toPrecision(2).toString() //setting number precision and turning it into a string
}