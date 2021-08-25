Fellow code warrior, we need your help! We seem to have lost one of our sequence elements, and we need your help to retrieve it!

## Problem:

Our sequence given was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

Write a function that accepts a sequence of unique integers between 0 and 9 (inclusive), and returns the missing element.
Examples:

## Example:

[0, 5, 1, 3, 2, 9, 7, 6, 4] --> 8
[9, 2, 4, 5, 7, 0, 8, 6, 1] --> 3

## Data:

array
integers

## Algorithm:

sort the array
create a counter variable
foreach number in the sorted array
{
if the number is equal to the counter (0=0 or 1=1)
increment the counter
}
"else" return counter

## Code:

using System;

public static class Kata
{
public static int GetMissingElement(int[] superImportantArray)
{
var counter = 0;
Array.Sort(superImportantArray, StringComparer.InvariantCulture);
foreach (var num in superImportantArray)
{
if (num == counter)
{
counter++;
}
}
return counter;

}
}
