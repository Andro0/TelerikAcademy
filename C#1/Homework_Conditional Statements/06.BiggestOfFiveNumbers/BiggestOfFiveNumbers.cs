//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter number c:");
        double numC = double.Parse(Console.ReadLine());
        Console.Write("Enter number d:");
        double numD = double.Parse(Console.ReadLine());
        Console.Write("Enter number e:");
        double numE = double.Parse(Console.ReadLine());

        if ((numA > numB) && (numA > numC) && (numA > numD) && (numA > numE))
        {
            Console.WriteLine("The biggest is: {0}", numA);
        }
        else
        {
            if ((numB > numA) && (numB > numC) && (numB > numD) && (numB > numE))
            {
                Console.WriteLine("The biggest is: {0}", numB);
            }
            else
            {
                if ((numC > numB) && (numC > numA) && (numC > numD) && (numC > numE))
                {
                    Console.WriteLine("The biggest is: {0}", numC);
                }
                else
                {
                    if ((numD > numB) && (numD > numC) && (numD > numA) && (numD > numE))
                    {
                        Console.WriteLine("The biggest is: {0}", numD);
                    }
                    else
                    {
                        if ((numE > numB) && (numE > numC) && (numE > numD) && (numE > numA))
                        {
                            Console.WriteLine("The biggest is: {0}", numE);
                        }
                        else
                        {
                            Console.WriteLine("The biggest is: {0}", numD);
                        }
                    }
                }
            }
        }
        
    }
}
