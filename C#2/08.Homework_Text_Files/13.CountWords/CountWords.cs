/*  Write a program that reads a list of words from the file words.txt and finds how many 
    times each of the words is contained in another file test.txt.
    The result should be written in the file result.txt and the words should be sorted by the 
    number of their occurrences in descending order.
    Handle all possible exceptions in your methods.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountWords
{
    class CountWords
    {
        static void Main()
        {
            string wordsPath = @"..\..\13.words.txt";
            string inputPath = @"..\..\13.text.txt";
            string resultPath = @"..\..\13.result.txt";
            string inputText = string.Empty;
            List<string> words = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(wordsPath))
                {
                    inputText = reader.ReadToEnd();
                }
                Match wordMatch =
                        Regex.Match(inputText, @"(?<word>\w+)", RegexOptions.IgnoreCase);
                while (wordMatch.Success)
                {
                    words.Add(wordMatch.Groups["word"].Value);
                    wordMatch = wordMatch.NextMatch();
                }
                using (StreamReader reader = new StreamReader(inputPath))
                {
                    inputText = reader.ReadToEnd();
                }
                Dictionary<string, int> dic = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    int counter = 0;
                    wordMatch = Regex.Match(inputText, word, RegexOptions.IgnoreCase);
                    while (wordMatch.Success)
                    {
                        counter++;
                        wordMatch = wordMatch.NextMatch();
                    }
                    dic.Add(word, counter);
                }
                dic.OrderBy(x => x.Value);
                string outputText = "";
                foreach (var item in dic)
                {
                    outputText += "The word " + item.Key + " is found " + item.Value + " times" + "\r\n";
                }

                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    writer.Write(outputText);
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
