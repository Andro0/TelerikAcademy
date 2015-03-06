/*  Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            string wordsPath = @"..\..\12.wordsFile.txt";
            string inputPath = @"..\..\12.textFile.txt";
            string resultPath = @"..\..\12.resultFile.txt";

            string text = string.Empty;
            List<string> words = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(wordsPath))
                {
                    text = reader.ReadToEnd();
                }

                Match wordMatch =
                       Regex.Match(text, @"(?<word>\w+)", RegexOptions.IgnoreCase);
                while (wordMatch.Success)
                {
                    words.Add(wordMatch.Groups["word"].Value);
                    wordMatch = wordMatch.NextMatch();
                }

                using (StreamReader reader =
                          new StreamReader(inputPath))
                {
                    text = reader.ReadToEnd();
                }

                for (int i = 0; i < words.Count; i++)
                {
                    text = text.Replace(words[i], "");
                }
                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    writer.Write(text);
                }
                Console.WriteLine("The file {0} has been created.",
                                   Path.GetFileName(resultPath));

                Console.WriteLine("File is in directory--> " +
                                    Path.GetFullPath(resultPath).Replace(Path.GetFileName(resultPath), String.Empty));
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileLoadException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EndOfStreamException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
