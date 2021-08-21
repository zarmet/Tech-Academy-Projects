function favNum () { //Define the function
    var favorites = { //Create a dictionary of people's favorite numbers
        Austin_Powers: "69", 
        Deep_Thought: "42",
        Satan: "666",
        Snoop: "420"
    }
    delete favorites.Snoop; //delete entry

    document.getElementById("dictionary").innerHTML=favorites.Snoop //call deleted entry and find undefined
}