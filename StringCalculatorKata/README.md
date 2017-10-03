# Test Driven Development Exercises

Learning how to develop software using TDD is often accomplished while practicing Katas. 
[KataCatalogue](http://codingdojo.org/cgi-bin/index.pl?KataCatalogue) has a number of different kata exercises.

Work with a partner to solve the following exercise while using the TDD approach.

## Kata String Calculator

Create a simple `StringCalculator` class with a method `int Add(string numbers)`.

### Step 1

    Write tests first and then implement the method to take 0, 1, or 2 numbers and return their sum. For an empty string it will return 0.

*Sample Output*
```
Add("") -> returns 0
Add("1") -> returns 1
Add("1,2") -> returns 3
```

**Hint** Begin with the simplest test case using an empty string and move to 1 then 2 numbers.

### Step 2

    Allow the Add method to handle an unknown amount of numbers.

*Sample Output*
```
Add("1,5,7") -> returns 13
Add("1,10,11,3") -> returns 25
```

### Step 3

    Allow the Add method to handle new lines between numbers (instead of commas)
    
*Sample Output*
```
Add("1\n2,3") -> returns 6
Add("3\n5\n2,4") -> returns 14 
```

**Note** The input `"1,\n"` is not valid. A comma will not end the line. You do not need to code for it.

### Step 4 (Bonus)

    Add Support for the input delimeters. To change a delimiter, the beginning of the string will contain a separate line that looks like "//delimeter\n[numbers,...]"
    
*Sample Output*
```
Add("//;\n1;2") -> the delimeter is a semi-colon and returns 3
Add("//!\n4!9") -> the delimeter is an exclamation point and returns 13
```

