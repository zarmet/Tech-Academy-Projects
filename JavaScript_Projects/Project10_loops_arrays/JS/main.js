const Fellows = ["Frodo", "Sam", "Merry", "Pippin", "Aragorn", "Gandalf", "Boromir", "Gimli", "Legolas"]; //assigning a constant list

function whileLoop () { //while loop
    var i=1; //counter
    var numb=""; //string to be printed
    while (i<10) { //logic
        numb+=i+"<br>" //adding numbers to the string
        document.getElementById("wloop").innerHTML=numb //writing the numbers in the HTML
        i++ //incrementing the counter
    }
    
}

function forLoop () { //for loop
    var content=""; //string to be printed
    var i=0; //counter
    var len=Fellows.length //length of constant list
    for (i=0; i<len; i++) { //ternary logic
        content+=Fellows[i]+"<br>"; //adding names to string
        document.getElementById("floop").innerHTML=content //writing the string in HTML
    }
}

Fellows.constructor; //constructor for turning const into an array

function callArray () {
    let member = { //creating an object with block scope
        name: "Gandalf", //properties
        job: " wizard",
        weapon_name: " Glamdring",
        weapon_type: " sword",
        description: function () { //creating a function to make a description
            var strang=this.name +" is a"+ this.job + " who fights with his trusty"+ this.weapon_type + "," + this.weapon_name + "!";
            return strang; //using return
        },
    }
    document.getElementById("gandalf").innerHTML=member.description();
    document.getElementById("array").innerHTML=Fellows[3]+" is a fool of a Took!"
}

function constFunct () { //altering the elements of the array
    let dead="deceased"
    Fellows[5]=dead; //changing elements
    Fellows[6]=dead;
    Fellows[9]="Smeagol"; //adding element
    var content=""; //relevant cariables for a for loop
    var i=0;
    var len=Fellows.length
    for (i=0; i<len; i++) { //for loop used to print list
        content+=Fellows[i]+"<br>";
        document.getElementById("floop").innerHTML=content
    }
}

