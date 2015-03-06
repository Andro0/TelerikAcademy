//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Linq;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            Console.Title = "Concat Two Files";
            try
            {
                string firstFilePath = @"..\..\02.Firstfile.txt";
                string secondFilePath = @"..\..\02.Secondfile.txt";
                string concatFilePath = @"..\..\02.Concatfile.txt";

                string fileToStringOne = string.Empty;
                string fileToStringTwo = string.Empty;

                using (StreamReader readerOne = new StreamReader(firstFilePath))
                {
                    fileToStringOne = readerOne.ReadToEnd();
                }
                using (StreamReader readerTwo = new StreamReader(secondFilePath))
                {
                    fileToStringTwo = readerTwo.ReadToEnd();
                }
                using (StreamWriter writer = new StreamWriter(concatFilePath))
                {

                    writer.WriteLine(fileToStringOne);
                    writer.WriteLine(fileToStringTwo);
                }

                Console.WriteLine(@"A {0} file named {1} has been created.",
                    Path.GetExtension(concatFilePath), Path.GetFileNameWithoutExtension(concatFilePath));
                Console.WriteLine(Environment.NewLine + "You can find it at " + Path.GetFullPath(concatFilePath));

            }
            catch (System.Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
