let turn = 1;
let moveNotation = "";
$("button").click(function () {

    //Getting the class name front
    var className = $(this).attr("class");

    if (turn == 1) {
        $("#screen").text("PLAYER 1 TURN");

        // Check sign font from font-awesome
        $(this).addClass("circle");
        moveNotation += "O"+className
        turn = 2;
    }
    else {
        $("#screen").text("PLAYER 2 TURN"); // Corrected the string
        // Cross sign font from font-awesome
        $(this).addClass("cross");
        moveNotation += "X" + className
        turn = 1;
    }

    // Disable the button after a symbol is placed
    $(this).prop("disabled", true);

    console.log("Notation: " + moveNotation);
});