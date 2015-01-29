/* Write an if-statement that takes two double variables a and b and exchanges their values if the first one
   is greater than the second one. As a result print the values a and b, separated by a space.*/

using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());

        if (numA > numB)
        {
            numA = numA - numB;
            numB = numA + numB;
            numA = numB - numA;
            Console.WriteLine(numA + " " + numB);
        }
        else
        {
            Console.WriteLine(numA + " " + numB);
        }


    }
}
