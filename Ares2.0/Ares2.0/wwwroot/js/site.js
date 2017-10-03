// Write your Javascript code.

/// <reference path="../jquery-3.1.1.js" />
// Game
$("#game").parents("body").on("keydown", function (e) {
    if (e.key == "ArrowRight") {
        goRight();
        checkNextStep();
    }
    else if (e.key == "ArrowUp") {
        goUp();
        checkNextStep();
        e.preventDefault();
        return false;
    }
    else if (e.key == "ArrowDown") {
        goDown();
        checkNextStep();
        e.preventDefault();
        return false;
    }
    else if (e.key == "ArrowLeft") {
        goLeft();
        checkNextStep();
    }

});

$("#btnRestart").on("click", restart);
});