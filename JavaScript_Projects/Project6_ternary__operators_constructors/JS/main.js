function voteFunction () {  //function that uses ternary operators
    var age, can_vote; //variables
    age=document.getElementById("age").value; //receives age from html input
    can_vote= (age<18) ? "You are too young":"You are old enough" //ternary statement to determine what message displays
    document.getElementById("vote").innerHTML=can_vote + " to vote." //display message
}


function Vehicle (make, model, year, color) { //constructor function
    this.Vehicle_make=make; //using this keyword to assign variables to the vehicle parent
    this.Vehicle_model=model;
    this.Vehicle_year=year;
    this.Vehicle_color=color;
}

var Bruce = new Vehicle("Wayne", "Tumbler", "2005", "black"); //creating objects from vehicle class and assigning them to variable
var Emmett = new Vehicle(" DMC", " DeLorean", " 1982", " stainless steel");
var James = new Vehicle("Aston Martin", "DB5", "1964", "silver");
var Bandit = new Vehicle("Pontiac", "Trans Am", "1977", "black");

function myFunction () { //main function called by html button
    var sentence = "Emmet drives a" + Emmett.Vehicle_color + Emmett.Vehicle_year + Emmett.Vehicle_model; //sentence concatenation
    function colorMe () { //created a nested function
        var blued = sentence.fontcolor("red") //change the font color
        document.getElementById("keywords_and_constructors").innerHTML=blued //write to html
    }
    colorMe (); //call the nested function
}


