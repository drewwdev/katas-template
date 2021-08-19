The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

make a longestSubString variable to hold current vowels
create a temporarySubString variable to hold current set of vowels
foreach letter in str
{
if the letter is equal to ("a", "e", "i", "o", or "u") append it to temporarySubString
when the next letter is not a vowel try to go to the next letter
when you get to the end of the word, if temporarySubString.Length is more than longestSubString.Length, replace temporarySubString with longestSubString
}
return longestSubString

    var longestSubString = "";
    var temporarySubString = "";
    var index = str[0];
    foreach (var letter in str)
      {
        Char.ToString(letter);
      }
    foreach (var letter in str)
      {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
          {
            temporarySubString += letter;
            index++;
          }
        else
          {
            index++;
          }
      if (temporarySubString.Length > longestSubString.Length)
        {
          longestSubString = temporarySubString;
        }
      else
      if (temporarySubString.Length < longestSubString.Length)
        {
          temporarySubString = longestSubString;
        }
      var longestSubStringLength = longestSubString.Length;
      return longestSubStringLength;
      }
