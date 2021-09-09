https://www.codewars.com/kata/5a4ea304b3bfa89a9900008e/train/typescript

Problem:
Given a number , Return _The Maximum number _ could be formed from the digits of the number given .
Notes

Only Natural numbers passed to the function , numbers Contain digits [0:9] inclusive.
Digit Duplications could occur , So also consider it when forming the Largest.

Example:
maxNumber (213) ==> return (321)
maxNumber (7389) ==> return (9873)
maxNumber (63729) ==> return (97632)
maxNumber (566797) ==> return (977665)
maxNumber (17693284) ==> return (98764321)

Data:
numbers
arrays

Algorithm:
convert the number to a string
split the string and put the strings into an array
sort the array
join each string in the array together
convert the string to a number

Code:
export function maxNumber(n: number): number {
const nAsString = n.toString()
const nAsStringArray = nAsString.split("", 100)
nAsStringArray.sort()
nAsStringArray.reverse()
const nAsStringAgain = nAsStringArray.join('')
const nAsNumber = parseInt(nAsStringAgain)
return nAsNumber; //your code here
}
