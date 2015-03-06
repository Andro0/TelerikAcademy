///Write a method that returns the last digit of given integer as an English word.

using System;
class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter integer:");
        int number = int.Parse(Console.ReadLine());
        
        string digitAsWord = LastDigitToWord(number);
        Console.WriteLine(digitAsWord);
    }

    static string LastDigitToWord(int number)
    {
        if (number<0)
        {
            number = -number;
        }
        int lastDigit = number % 10;
        string word = string.Empty;
        switch (lastDigit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }
        return word;
    }
}
