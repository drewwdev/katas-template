This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.

go through each letter in the string
add that letter to a new string
each time the letter changes, add 1 to the amount of times that letter is added to the string, and separate the different letters with a dash -

      s = s.ToLower();
      var newString = "";
      for (var index = 0; index < s.Length; index ++)
      {
        for (var letterIndex = 0; letterIndex <= index; letterIndex ++)
          {
            if (letterIndex == 0)
              {
                newString += Char.ToUpper(s[index]);
              }
            else
              {
                newString += s[index];
              }
          }
          newString += "-";
      }
    var substring = newString.Substring(0, newString.Length - 1);
    return substring;
