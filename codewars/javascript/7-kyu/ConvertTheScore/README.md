https://www.codewars.com/kata/5b6c220fa0a661fbf200005d/train/javascript

Problem:
You are working at a lower league football stadium and you've been tasked with automating the scoreboard.
The referee will shout out the score, you have already set up the voice recognition module which turns the ref's voice into a string, but the spoken score needs to be converted into a pair for the scoreboard!
Either teams score has a range of 0-9, and the ref won't say the same string every time e.g.

Example:
e.g. "The score is four nil" should return [4,0]
"new score: two three" [2,3]
"two two" [2,2]
"Arsenal just conceded another goal, two nil" [2,0]

Data:
array
number
variables
string
stringconverter
loop

Algorithm:
for every word in a string look for the following words:
one, two, three, four, five, six, seven, eight, nine, nil
if the string currently selected is equal to one of the written numbers add the numeric version of that number to an array
once you finish going through the whole string return the array with two numbers

Code:
function scoreboard(string) {
const numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
const writtenNumbers = ['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'nil']

const words = string.split(' ')
const lastWord = words.length - 1
const secondToLastWord = words.length - 2
const score = [(secondToLastWord), (lastWord)]
return score

}
