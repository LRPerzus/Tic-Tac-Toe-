$(document).ready(function () {
    function check(symbol) {
        if ($(".square#1").hasClass(symbol) &&
            $(".square#2").hasClass(symbol) &&
            $(".square#3").hasClass(symbol)) {
            $(".square#1").css("color", "green");
            $(".square#2").css("color", "green");
            $(".square#3").css("color", "green");
            return true;
        } else if ($(".square#4").hasClass(symbol)
            && $(".square#5").hasClass(symbol)
            && $(".square#6").hasClass(symbol)) {
            $(".square#4").css("color", "green");
            $(".square#5").css("color", "green");
            $(".square#6").css("color", "green");
            return true;
        } else if ($(".square#7").hasClass(symbol)
            && $(".square#8").hasClass(symbol)
            && $(".square#9").hasClass(symbol)) {
            $(".square#7").css("color", "green");
            $(".square#8").css("color", "green");
            $(".square#9").css("color", "green");
            return true;
        } else if ($(".square#1").hasClass(symbol)
            && $(".square#4").hasClass(symbol)
            && $(".square#7").hasClass(symbol)) {
            $(".square#1").css("color", "green");
            $(".square#4").css("color", "green");
            $(".square#7").css("color", "green");
            return true;
        } else if ($(".square#2").hasClass(symbol)
            && $(".square#5").hasClass(symbol)
            && $(".square#8").hasClass(symbol)) {
            $(".square#2").css("color", "green");
            $(".square#5").css("color", "green");
            $(".square#8").css("color", "green");
            return true;
        } else if ($(".square#3").hasClass(symbol)
            && $(".square#6").hasClass(symbol)
            && $(".square#9").hasClass(symbol)) {
            $(".square#3").css("color", "green");
            $(".square#6").css("color", "green");
            $(".square#9").css("color", "green");
            return true;
        } else if ($(".square#1").hasClass(symbol)
            && $(".square#5").hasClass(symbol)
            && $(".square#9").hasClass(symbol)) {
            $(".square#1").css("color", "green");
            $(".square#5").css("color", "green");
            $(".square#9").css("color", "green");
            return true;
        } else if ($(".square#3").hasClass(symbol)
            && $(".square#5").hasClass(symbol)
            && $(".square#7").hasClass(symbol)) {
            $(".square#3").css("color", "green");
            $(".square#5").css("color", "green");
            $(".square#7").css("color", "green");
            return true;
        } else {
            return false;
        }
    }



    let turn = 1;
    let moveNotation = '';
    var movesInput = document.getElementById('moveNotation')
    var winnerInput = document.getElementById('winner')
    $("#screen").text("PLAYER 1 TURN");
    $("button").click(function () {

        //Getting the class name front
        var className = $(this).attr("id");

        if (turn == 1) {
            // Check sign font from font-awesome
            $(this).addClass("circle");
            if (check("circle")) {
                moveNotation += 'O' + className;
                $(".square").prop("disabled", true);
                $("#screen").text("PLAYER 1 WINS");
                movesInput.value = moveNotation;
                winnerInput.value = 'O';


            }
            else {
                moveNotation += 'O' + className + ',';
                turn = 2;
                $("#screen").text("PLAYER 2 TURN");

            }

        }
        else {
            // Cross sign font from font-awesome
            $(this).addClass("cross");
            if (check("cross")) {
                moveNotation += 'X' + className;
                $(".square").prop("disabled", true);
                $("#screen").text("PLAYER 2 WINS");
                movesInput.value = moveNotation;
                winnerInput.value = 'X';


            }
            else {
                moveNotation += 'X' + className + ',';
                turn = 1;
                $("#screen").text("PLAYER 1 TURN");


            }

        }

        // Disable the button after a symbol is placed
        $(this).prop("disabled", true);
        console.log("Notation: " + moveNotation);

    });
})

