/*  Write a method that adds two positive integer numbers represented as arrays of digits
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Linq;
class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter positive integer one:");
        string numOne = Console.ReadLine();
        Console.Write("Enter positive integer two:");
        string numTwo = Console.ReadLine();

        int[] arrayNumOne = new int[numOne.Length];
        int[] arrayNumTwo = new int[numTwo.Length];

        ToArray(numOne, arrayNumOne);
        ToArray(numTwo, arrayNumTwo);

        int[] sum = new int[Math.Max(numOne.Length, numTwo.Length) + 1];
        if (arrayNumOne.Length > arrayNumTwo.Length)
        {
            Array.Copy(arrayNumTwo, sum, arrayNumTwo.Length);
            SumArrays(sum, arrayNumOne);
        }
        else
        {
            Array.Copy(arrayNumOne, sum, arrayNumOne.Length);
            SumArrays(sum, arrayNumTwo);
        }

        Array.Reverse(sum);
        int i = 0;
        if (sum[i] == 0) i++;
        Console.Write("The sum of numbers is ");
        for (; i < sum.Length; i++)
        {
            Console.Write(sum[i]);
        }
        Console.WriteLine();
    }

    private static void SumArrays(int[] sum, int[] array1)
    {
        int oneOnMind = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if ((sum[i] + array1[i] + oneOnMind) > 9)
            {
                sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                oneOnMind = 1;
            }
            else
            {
                sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                oneOnMind = 0;
            }
        }
        if (oneOnMind == 1) sum[sum.Length - 1] = 1;
    }

    private static void ToArray(string numOne, int[] arrayNum1)
    {
        for (int i = 0, j = numOne.Length - 1; j >= 0; i++, j--)
        {
            arrayNum1[i] = numOne[j] - '0';
        }
    }


}

