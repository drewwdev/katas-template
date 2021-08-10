Simple, given a string of words, return the length of the shortest word(s).
String will never be empty and you do not need to account for different data types.

1. split the sentence into words in a list using .split
2. create var smallestWord = words[0]
3. foreach word in the new list of words
4. if word < words[0]
5. replace smallestWord with word
6. return smallestWord after looping through list of words
