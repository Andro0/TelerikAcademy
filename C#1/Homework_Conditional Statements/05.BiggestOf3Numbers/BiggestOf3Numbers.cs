//Write a program that finds the biggest of three numbers.


using System;
class BiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter number c:");
        double numC = double.Parse(Console.ReadLine());

        if (numA > numB)
        {
            if (numA > numC)
            {
                Console.WriteLine("The biggest is: {0}", numA);
            }
            else
            {
                Console.WriteLine("The biggest is: {0}", numC);
            }
        }
        else
        {
            if (numB > numC)
            {
                Console.WriteLine("The biggest is: {0}", numB);
            }
            else
            {
                Console.WriteLine("The biggest is: {0}", numC);
            }
        }
    }
}