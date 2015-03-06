//Write a program to check if in a given expression the brackets are put correctly.

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression to check its brackets:");
        string expression = Console.ReadLine();
        int countLeftBracket = 0;
        int countRightBracket = 0;
        bool isCorrect = true;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countLeftBracket++;
            }
            if (expression[i] == ')')
            {
                countRightBracket++;
            }
            if (countRightBracket > countLeftBracket)
            {
                isCorrect = false;
            }
        }
        if (countLeftBracket == countRightBracket)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("The expression is NOT correct");
        }
    }
}