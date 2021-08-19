Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.

Examples
Digits.Explode("312") = "333122"
Digits.Explode("102269") = "12222666666999999999"

go through each number in a string
add that number to a new string x amount of times: x being the value of the number
when there are no more numbers in the string, return the new string as result

    var newString = "";
    foreach (var number in s)
    {
      for (var index = 0; index < number - '0'; index ++)
        {
          newString += number;
        }
    }
    return newString;
