/*  Write a program that extracts from given XML file all the text without the tags.
    Example:
    <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>
    Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            string inputPath = @"..\..\10.xmlFile.xml";
            string resultPath = @"..\..\10.xmlTextOnly.txt";

            try
            {
                StringBuilder result = new StringBuilder();
                StringBuilder current = new StringBuilder();
                using (StreamReader reader = new StreamReader(inputPath))
                {
                    string inputText = reader.ReadToEnd();
                    bool inTag = false;

                    foreach (var letter in inputText)

                        if (inTag)
                        {
                            if (letter == '>')
                            {
                                inTag = false;
                            }
                            continue;
                        }
                        else
                        {
                            if (letter == '<')
                            {
                                if (current.Length > 0)
                                {
                                    result.AppendLine(current.ToString());
                                    current.Clear();
                                }
                                inTag = true;
                            }
                            else
                            {
                                current.Append(letter);
                            }

                        }
                }
                using (StreamWriter writer = new StreamWriter(resultPath, false))
                {
                    writer.Write(result.ToString());
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

        }
    }
}

