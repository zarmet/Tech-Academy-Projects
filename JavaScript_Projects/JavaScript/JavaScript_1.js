var c = document.getElementById("graphics");
var ctx = c.getContext("2d");
var my_gradient = ctx.createLinearGradient(0, 0, 0, 480);
my_gradient.addColorStop(0, "darkred");
my_gradient.addColorStop(1, "black");
ctx.fillStyle = my_gradient;
ctx.fillRect(0, 0, 725, 485);



function helloWorld () {
    var a=document.getElementsByClassName("click");
    a[0].innerHTML="See? I told you.";
}

function theBox () {
    var c = document.getElementById("graphics");
    var ctx = c.getContext("2d");
    var img = document.getElementById("brad");
    ctx.drawImage(img, 10, 10);
}


