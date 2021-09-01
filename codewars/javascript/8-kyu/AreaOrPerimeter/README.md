https://www.codewars.com/kata/5ab6538b379d20ad880000ab/javascript

Problem:
You are given the length and width of a 4-sided polygon. The polygon can either be a rectangle or a square.
If it is a square, return its area. If it is a rectangle, return its perimeter.

Example:
area_or_perimeter(6, 10) --> 32
area_or_perimeter(3, 3) --> 9

Data:
if statements or ternaries

Algorithm:
if length = width => shape is square => multiply length \* width and return area
else length != width => shape is a rectangle => add (length times 2) + (width times 2) then return perimeter

Code:
if else statement:
if (l===w){
theArea = l \* w
return theArea
} else {
perimeter = 2\*(l+w)
return perimeter
}

ternary:
return l===w ? l \* w : 2\*(l+w)
