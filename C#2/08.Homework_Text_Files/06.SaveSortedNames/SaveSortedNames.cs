/*  Write a program that reads a text file containing a list of strings, 
    sorts them and saves them to another text file.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            string stringPath = @"..\..\06.strings.txt";
            string sortedPath = @"..\..\06.sortedStrings.txt";

            try
            {
                List<string> stirngs = new List<string>();

                using (StreamReader reader = new StreamReader(stringPath))
                {
                    stirngs = reader.ReadToEnd()
                        .Split('\n')
                        .Select(x => x.Trim())
                        .OrderBy(x => x)
                        .ToList();

                    File.WriteAllLines(sortedPath, stirngs);

                    Console.WriteLine("A file {0} has been created with the sorted strings.",
                                            Path.GetFileName(sortedPath));

                    Console.WriteLine("File is in directory--> " +
                        Path.GetFullPath(sortedPath).Replace(Path.GetFileName(sortedPath), String.Empty));

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
        }

    }

}
