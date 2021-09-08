/*function to get task from input*/
function getTodos () {
    var todos = new Array;
    /*loads saved task array from browser memory*/
    var todoStr = localStorage.getItem('todo');
    /*If the input is not null then JSON.parse 
    will make the task a JavaScript object.*/
    if (todoStr !== null) {
        todos = JSON.parse(todoStr);
    }
    return todos;
}


    // Get the input field
var input = document.getElementById("task");

    // Execute a function when the user releases a key on the keyboard
input.addEventListener("keyup", function(event) {
    // Number 13 is the "Enter" key on the keyboard
    if (event.keyCode === 13) {
        // Trigger the button element with a click
        document.getElementById("add").click();
    }
});


/*function to add input to the first function*/
function add() {
    /*retrieves the task input and stores it as a variable*/
    var task = document.getElementById('task').value;

    /*get array and push task to it*/
    var todos = getTodos ();
    todos.push(task);
    /*convert task to JSON string and store it in browser memory*/
    localStorage.setItem('todo', JSON.stringify(todos));
    document.getElementById("task").value = "";
    show ();

    return false;


}

function remove () {
    var id = this.getAttribute ('id');
    var todos = getTodos ();
    todos.splice(id, 1);
    localStorage.setItem('todo', JSON.stringify(todos));
    show ();    
}

/*function to display tasks on screen*/
function show () {
    var todos = getTodos ();

    /*set up tasks as a bulleted list*/
    var html = '<ul>';
    /*display tasks in order of input*/
    for (var i = 0; i < todos.length; i++) {
        /*this creates the string displayed as well as the close button*/
        html += '<li>' + todos[i] + '<button class="remove" id="'+i+'">x</button></li>';
    };
    html += '</ul>';
    /*displays the task list*/
    document.getElementById('todos').innerHTML = html;
    var buttons = document.getElementsByClassName('remove');
    for (var i = 0; i<buttons.length; i++) {
        buttons[i].addEventListener("click", remove);
    }
}

/*Display the inputted task when the button is clicked*/
document.getElementById('add').addEventListener("click", add);
    


show ();