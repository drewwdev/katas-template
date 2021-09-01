https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/typescript

Problem:
Return the number (count) of vowels in the given string.
We will consider a, e, i, o, u as vowels for this Kata (but not y).
The input string will only consist of lower case letters and/or spaces.

Example:
string = dog => contains 1 vowel (o) => return 1
string = cougar => contains 3 vowels (o, u, a) => return 3

Data:
Arrays

Algorithm:
go through each letter in each string until you reach the end
if a vowel (a, e, i, o, u) is the current letter add it to a counter
when the end of the letter is reached return the counter

Code:
