/*  Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum. */

using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter number of array elements N=");
        int numElements = int.Parse(Console.ReadLine());
        Console.Write("Enter how many elements to sum (K<=N) K=");
        int sumElements = int.Parse(Console.ReadLine());
        int[] intArr = new int[numElements];
        long sum = 0;
        Console.WriteLine("\nEnter array elements");
        for (int i = 0; i < numElements; i++)
        {
            Console.Write("Enter array element {0} of {1}: ", i, numElements);
            intArr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(intArr);
        for (int i = numElements - sumElements; i < numElements; i++)
        {
            Console.Write("{0}", intArr[i]);
            if (i < numElements - 1)
            {
                Console.Write(", ");
            }
            sum += intArr[i];
        }
        Console.WriteLine("\nMax sum of K={1} element/s is: {0}", sum, sumElements);
    }

}