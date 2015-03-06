//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        const string NEW = "start";
        const string OLD = "finish";
        static void Main()
        {
            string inputPath = @"..\..\08.input.txt";
            string outputPath = @"..\..\08.output.txt";

            try
            {
                using (StreamReader reader = new StreamReader(inputPath))
                {
                    StringBuilder currentLine;
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        while (!reader.EndOfStream)
                        {
                            currentLine = new StringBuilder(reader.ReadLine());
                            writer.WriteLine(Replace(currentLine));
                        }
                        Console.WriteLine("A file {0} has been created with the replaced text.",
                                                    Path.GetFileName(outputPath));
                        Console.WriteLine("File is in directory--> " +
                        Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));


                    }
                }
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
        }



        private static string Replace(StringBuilder currentLine)
        {
            int startIndex = 0;
            string checkLine = currentLine.ToString();
            while (startIndex < currentLine.Length &&
                checkLine.IndexOf(NEW, StringComparison.OrdinalIgnoreCase) != -1)
            {
                startIndex = checkLine.IndexOf(NEW, StringComparison.OrdinalIgnoreCase);
                bool startOfWord = (startIndex == 0 ||
                    !Char.IsLetterOrDigit(currentLine[startIndex - 1]));

                bool endOfWord = ((startIndex + NEW.Length) == currentLine.Length ||
                    !Char.IsLetterOrDigit(currentLine[startIndex + NEW.Length]));

                if (startOfWord && endOfWord)
                {
                    currentLine = currentLine
                        .Replace(currentLine.ToString()
                        .Substring(startIndex, NEW.Length),
                        OLD, startIndex, NEW.Length);
                }

                startIndex += OLD.Length;
                checkLine = currentLine.ToString().Substring(startIndex);
                checkLine = checkLine.PadLeft(currentLine.Length, '*');
            }

            return currentLine.ToString();
        }
    }

}
