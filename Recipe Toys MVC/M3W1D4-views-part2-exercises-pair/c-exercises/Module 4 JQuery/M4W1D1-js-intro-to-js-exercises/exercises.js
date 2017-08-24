<<<<<<< HEAD
﻿function sumDouble(x, y) {
    var sum = x + y;
    if (x === y) {
        sum = sum * 2;
    }
    return sum;
}

function hasTeen(a, b, c) {

    if (a >= 13 && a <= 19) {

        return true;
    }
    else if (b >= 13 && b <= 19) {
        return true;
    }
    else if (c >= 13 && c <= 19) {
        return true;
    }
    else {
        return false;
    }
}

function lastDigit(a, b) {
    return (a % 10 == b % 10);
}

function seeColor(str) {

    if (str.startsWith("red")) {
        return "red";
    }
    else if (str.startsWith("blue")) {
        return "blue"
    }
    else {
        return "";
    }
}

function middleThree(str) {

    var myResult = (str.length / 2) ;
    return str.substring(myResult-1, myResult+2);
}

function frontAgain(str) {

    var result = str.length;

    if (result >= 2) {
        return str.substring(0, 2)===(str.substring(result - 2, result));

    }
    else {
        return false;
    }
}

function alarmClock(day, vacation) {

    if (day > 0 && day < 6) {

        if (vacation == false) {

            return "7:00";
        }
        else {
            return "10:00";
        }
    }
    else if (vacation == true) {

        if (day == 0 || day == 6) {

            return "off";
        }
        else {
            return "10:00";
        }
    }
}

function makeMiddle(nums) {

    var length = nums;

    var middle = nums.length / 2;
    length[0] = nums[middle - 1];
    length[1] = nums[middle];

    return length;
}

function oddOnly(nums) {

    var mynums = [1, 3, 5, 7, 9, 11];

    for (var i = 0; i < nums.length; i++) {
        if ((nums[i] % 2) != 0) {
            return mynums;
        }
        else if((nums[i] % 2) === 0){
            return [];
        }
      
    }
}

function weave(nums, bums) {

    var comb = [];

    for (var i = 0; i < nums.length; i+=1) {
        for (var j = 0; j < bums.length; j+=1) {
            if (nums.length <= 5) {

                comb[0] = nums[0];
                comb[1] = bums[0];
                comb[2] = nums[1];
                comb[3] = bums[1];
                comb[4] = nums[2];
            }
            else if (nums.length >= 5) {
                comb[0] = nums[0];
                comb[1] = bums[0];
                comb[2] = nums[1];
                comb[3] = bums[1];
                comb[4] = nums[2];
                comb[5] = bums[2];
                comb[6] = nums[3];
                comb[7] = bums[3];
            }
        }
 
    }

    return comb;
}


function cigarParty(cigars, isWeekend) {

    if (cigars >= 40 && cigars <= 60) {

        return true;
    }
    else if (isWeekend) {
        return true;
    }
    else {
        return false;
    }

}

function stringSplosion(str) {
    var result = "";
    for (var i = 0; i < str.length; i++)
    {
        result += str.substring(0, i + 1);
    }
    return result;
}

function fizzBuzz() {

    for (var i = 1; i <= 100; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
            console.log("FizzBuzz");
        }
        else if (i % 3 == 0) {
            console.log("Fizz");
        }
        else if (i % 5 == 0) {
            console.log("Buzz");
        }
        else {
            console.log(i);
        }
    }
    
}

function countValues(arr) {
    var a = [], b = [], prev;

    arr.sort();
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] !== prev) {
            a.push(arr[i]);
            b.push(1);
        } else {
            b[b.length - 1]++;
        }
        prev = arr[i];
    }

    return [a, b];
}

function reverseArray(nums) {
    for (var i = 0; i < nums.length / 2; i++)
    {
        var temp = nums[i];
        nums[i] = nums[nums.length - i - 1];
        nums[nums.length - i - 1] = temp;

        return nums;
    }
}
function blackJack(a, b) {

    if (a > b && a <= 21 && b <= 21) {
        return a;
    }
    if (b > a && b <= 21 && a <= 21) {
        return b;
    }
    else if (a > 21 && b > 21) {
        return 0;
    }
    else {
        return a;
    }
}

=======
﻿function countValues(input) {
    var count = {};
    for (var i = 0; i < input.length; i++) {
        if (isNaN(count[input[i]])) {
            count[input[i]] = 0;
        }
        count[input[i]] += 1;
    }
    return count;
}
>>>>>>> cf326e07c86f5646411603ab4086be47f7dab316
