var x=73 //Global variable

function addFunction () { //working function
    var y=26, z=x+y; //local variables
    console.log(z) //console log for debugging
    document.getElementById("add").innerHTML=z //displaying output
}

function subFunction () { //broken function
    var w=x-y //local variables, missing y
    console.log(w) //console log debugging
    document.getElementById("sub").innerHTML=w
}

function getDate () { //function for sole if statement
    if (new Date().getHours()<18) { //if statement
        document.getElementById("greeting").innerHTML="Lovely day, isn't it?" //what to display if conditions are met
    }
}

function numGuesser () { //function to replace Time_function()
    const ans=6; //Answer to the game
    guess=document.getElementById("guess").value //retrieve guess from html input

    if (guess > 10 || guess < 1) { //if statement to scold users for not following rules
        document.getElementById("response").innerHTML="You're not so good with instructions... Between 1 and 10."
    }

    else if (guess==ans) { //elif for when user wins
        document.getElementById("response").innerHTML="Color me impressed, you did it!"
    }

    else { //else the number is not correct
        document.getElementById("response").innerHTML="Nope, not it. Better luck next time!"
    }
}