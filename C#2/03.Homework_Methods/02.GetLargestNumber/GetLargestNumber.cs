/*  Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

using System;
    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("Enter number one:");
            int numOne = int.Parse(Console.ReadLine());
            Console.Write("Enter number two:");
            int numTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter number three:");
            int numThree = int.Parse(Console.ReadLine());
            int maxNum = GetMax(GetMax(numOne, numTwo), numThree);
            Console.WriteLine("Max number from {0}, {1}, {2} is {3}",numOne,numTwo,numThree,maxNum);
        }
        static int GetMax(int num1,int num2)
        {
            if (num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
