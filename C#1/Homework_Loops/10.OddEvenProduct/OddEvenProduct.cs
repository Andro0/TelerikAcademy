/*  You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;
class OddEvenProduct
{
    static void Main()
    {
        string nums = Console.ReadLine();
        int productEven = 1;
        int productOdd = 1;
        string[] numbers = nums.Split(' ');

        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= Convert.ToInt32(numbers[i]);
            }
            else
            {
                productEven *= Convert.ToInt32(numbers[i]);
            }

        }

        if (productOdd == productEven)
        {
            Console.WriteLine("Product={0},  Result-->{1}", productEven, "Yes");
        }
        else
        {
            Console.WriteLine("Odd product={0}\nEven product={1},  Result-->{2}", productOdd, productEven, "No");
        }

    }
}
