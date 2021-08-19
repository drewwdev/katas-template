Complete the solution so that it reverses the string passed into it.

var reverseString = "";

var length = str.Length - 1;

while (length >= 0)  
 {  
 reverseString += str[length];  
 length--;  
 }  
 return reverseString;
