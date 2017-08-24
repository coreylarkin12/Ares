/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.

function presentialDivs() {
    $("#btnPresident").click(function () {
        $("div").addClass("president");
        
    });
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    $("#btnFoundingFather").click(function () {
        $("#george-washington").addClass("founding-father");

    });
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    $("#btnRepublicans").click(function () {
        $(".Republican").addClass("red");
    });
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    $("#btnDemocrats").click(function () {
        $(".Democratic").addClass("blue");

    });
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    $("#btnOther").click(function () {
        $(".Nonpartisan").addClass("gold");
        $(".Federalist").addClass("gold");
        $(".Democratic-Republican").addClass("gold");
        $(".Whig").addClass("gold");
        $(".National-Union").addClass("gold");

    });
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    $("#btnJames").click(function () {
        $(".James").addClass("james");

    });
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    $("#btnBeginningOfCentury").click(function () {
        $("id=-Thomas Jefferson-").addClass("beginningOfCentury");
        $("id=-Theodore Roosevelt-").addClass("beginningOfCentury");
        $("id=-George W. Bush-").addClass("beginningOfCentury");
    });
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    $("#btnEndOfCentury").click(function () {
        $("id=-John Adams-").addClass("endOfCentury");
        $("id=-Bill Clinton-").addClass("endOfCentury");
        $("id=-William McKinley-").addClass("endOfCentury");
    });
  

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    $("#btnAppearOnCurrency").click(function () {
        $("id=-George Washington-").addClass("appearOnCurrency");
        $("id=-Andrew Jackson-").addClass("appearOnCurrency");
        $("id=-Abraham Lincoln-").addClass("appearOnCurrency");
        $("id=-Thomas Jefferson-").addClass("appearOnCurrency");
        $("id=-James Madison-").addClass("appearOnCurrency");
        $("id=-Ulysses S. Grant-").addClass("appearOnCurrency");
        $("id=-Grover Cleveland-").addClass("appearOnCurrency");
        $("id=-William McKinley-").addClass("appearOnCurrency");
        $("id=-Woodrow Wilson-").addClass("appearOnCurrency");
        $("id=-Franklin D. Roosevelt-").addClass("appearOnCurrency");
        $("id=-Dwight D. Eisenhower-").addClass("appearOnCurrency");
        $("id=-John F. Kennedy-").addClass("appearOnCurrency");
    });

}



