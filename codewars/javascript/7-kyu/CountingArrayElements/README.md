https://www.codewars.com/kata/5569b10074fe4a6715000054/train/javascript

Hint:
Hint for today's codewar. JavaScript objects can be helpful!
const someObject = { }

someObject[someKey] = 42

Problem:
Write a function that takes an array and counts the number of each unique element present.

Example:
count(['james', 'james', 'john'])
#=> { 'james': 2, 'john': 1}

Data:
objects
arrays

Algorithm:
create an empty object to add strings from the array to
go through each string in an array
for each string add it to the object with a value of 1
if the string already exists as a property in the object, add 1 to its value
return the object

Code:
function count(array){

const arrayObject = {}

return arrayObject
}
