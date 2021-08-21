function magicButton () { //Magic Button Function
    var str1="Congratulations! ", str2="Someone on Earth just farted!"; //var:str Message to be displayed
    str1+=str2 //Concatenating the strings
    var fart=str1.fontcolor("green"); //Statement to change the font color to green
    document.getElementById("text").innerHTML=fart; //Statement to affect the button tag in HTML
}