//  Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter number of elements for the First array:");
        int numOneArray = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Enter number of elements for the Second array:");
        int numTwoArray = int.Parse(Console.ReadLine());
        int[] arrOne = new int[numOneArray];
        int[] arrTwo = new int[numTwoArray];
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < numOneArray; i++)
        {
            Console.Write("Enter element {0} to First array:", i);
            arrOne[i] = int.Parse(Console.ReadLine());
        }
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < numTwoArray; i++)
        {
            Console.Write("Enter element {0} to Second array:", i);
            arrTwo[i] = int.Parse(Console.ReadLine());
        }

        if (numOneArray == numTwoArray)
        {
            bool areEqual = true;
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    areEqual = false;
                    break;
                }

            }
            if (areEqual)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(("ARRAY ELEMENTS ARE EQUAL".PadLeft(37)).PadRight(50));
                Console.WriteLine(new string('-', 50));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(("FIRST array".PadLeft(15)).PadRight(30));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(("SECOND array".PadLeft(15)).PadRight(30));

                for (int i = 0; i < arrOne.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(("Element {0} is {1}".PadLeft(20)).PadRight(34), i, arrOne[i]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(("Element {0} is {1}".PadLeft(20)).PadRight(30), i, arrTwo[i]);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Both arrays have equal number of elements but different values");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Both arrays have different number of elements");
            Console.ForegroundColor = ConsoleColor.White;
        }








    }
}