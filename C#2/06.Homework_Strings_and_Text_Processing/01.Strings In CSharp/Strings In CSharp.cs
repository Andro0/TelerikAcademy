/*  
 * Describe the strings in C#.
 * What is typical for the string data type?
 * Describe the most important methods of the String class.
 
   
  
 *    Strings are sequences of Unicode characters.

 *    Strings are represented by System.String objects in .NET Framework. 
      String objects contain an immutable (read-only) sequence of characters.
      Strings use Unicode to support multiple languages and alphabets.
      Strings are stored in the dynamic memory (managed heap).
      System.String is a reference type.
      String objects are like arrays of characters (char[]).
      Have fixed length (String.Length).
      Elements can be accessed directly by index.
      The index is in the range [0...Length-1].

  *   string.Compare(string, string) - Dictionary-based string comparison.
      string.Concat(string, string) - Concatenates strings.
      string.IndexOf() and string.LastIndexOf - Finding a character or substring within given string.
      string.Substring() - Extracting substrings.
      string.Split() - returns an array of strings, splits the string by given separator.
      string.ToLower()
      string.ToUpper()
      string.Trim()
      string.Replace()
      string.Remove()
  */