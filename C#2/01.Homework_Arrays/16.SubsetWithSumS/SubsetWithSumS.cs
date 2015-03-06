/*  We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetWithSumS
{
    static void Main()
    {
        Console.Write("Enter what sum to check in the array: S=");
        int sumToSearch = int.Parse(Console.ReadLine());

        Console.Write("Enter array elements separated by space:");
        string input = Console.ReadLine();

        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }


        List<int> usedNumbers = new List<int>();
        List<int> unusedNumbers = new List<int>();

        usedNumbers.Add(intArr[0]);
        unusedNumbers = intArr.ToList();
        unusedNumbers.RemoveAt(0);
        int Sum = usedNumbers.Sum();
        int flagCounter = 0;
        while (Sum != sumToSearch)
        {
            if (sumToSearch > Sum && unusedNumbers.Count == 0)
            {
                Console.Write("No subset elements equalt to {0}", sumToSearch);
                Console.WriteLine();
                return;
            }
            if (sumToSearch > Sum && unusedNumbers.Count != 0)
            {
                usedNumbers.Add(unusedNumbers[0]);
                unusedNumbers.RemoveAt(0);
                Sum = usedNumbers.Sum();
            }
            else
            {
                unusedNumbers.Add(usedNumbers[usedNumbers.Count - 1]);
                usedNumbers.RemoveAt(usedNumbers.Count - 1);
                Sum = usedNumbers.Sum();
            }


            flagCounter++;
            if (flagCounter == intArr.Length * intArr.Length)
            {
                Console.Write("No subset elements equalt to {0}", sumToSearch);
                Console.WriteLine();
                return;
            }
        }

        Console.Write("yes {");
        foreach (int num in usedNumbers)
        {
            Console.Write(" {0}", num);
        }
        Console.WriteLine(" }");

    }

}
