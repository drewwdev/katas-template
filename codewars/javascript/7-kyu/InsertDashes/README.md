https://www.codewars.com/kata/55960bbb182094bc4800007b/train/javascript

Problem:
Write a function insert_dash(num) / insertDash(num) / InsertDash(int num) that will insert dashes ('-') between each two odd numbers in num. Note that the number will always be non-negative (>= 0).

Example:
For example: if num is 454793 the output should be 4547-9-3. Don't count zero as an odd number.

Data:

Algorithm:
Go through each number
If the first number is odd and the next number is odd, splice a dash between them

Code:
