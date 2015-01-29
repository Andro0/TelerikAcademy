//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number in range [0...999]:");
        int num = int.Parse(Console.ReadLine());
        int h = (num / 100);        //456    //4
        int t = (num % 100) / 10;            //5
        int tt = (num % 100);                //56
        int ttt = t * 10;                    //50
        int e = num % 10;                    //6
        string hundreds;
        string tenths;
        string digits;
        string teens;

        switch (h)
        {
            case 1: hundreds = "One hundred"; break;
            case 2: hundreds = "Two hundred"; break;
            case 3: hundreds = "Three hundred"; break;
            case 4: hundreds = "Four hundred"; break;
            case 5: hundreds = "Five hundred"; break;
            case 6: hundreds = "Six hundred"; break;
            case 7: hundreds = "Seven hundred"; break;
            case 8: hundreds = "Eight hundred"; break;
            case 9: hundreds = "Nine hundred"; break;
            default: hundreds = "";
                break;
        }

        switch (e)
        {
            case 0: digits = "zero"; break;
            case 1: digits = "one"; break;
            case 2: digits = "two"; break;
            case 3: digits = "three"; break;
            case 4: digits = "four"; break;
            case 5: digits = "five"; break;
            case 6: digits = "six"; break;
            case 7: digits = "seven"; break;
            case 8: digits = "eight"; break;
            case 9: digits = "nine"; break;
            default: digits = "";
                break;
        }

        switch (ttt)
        {
            case 10: tenths = "ten"; break;
            case 20: tenths = "twenty"; break;
            case 30: tenths = "thirty"; break;
            case 40: tenths = "forty"; break;
            case 50: tenths = "fifty"; break;
            case 60: tenths = "sixty"; break;
            case 70: tenths = "seventy"; break;
            case 80: tenths = "eight"; break;
            case 90: tenths = "ninety"; break;
            default: tenths = "";
                break;
        }

        switch (tt)
        {
            case 11: teens = "eleven"; break;
            case 12: teens = "twelve"; break;
            case 13: teens = "thirteen"; break;
            case 14: teens = "fourteen"; break;
            case 15: teens = "fifteen"; break;
            case 16: teens = "sixteen"; break;
            case 17: teens = "seventeen"; break;
            case 18: teens = "eighteen"; break;
            case 19: teens = "nineteen"; break;
            default: teens = ""; break;
        }

        if (num >= 0 && num <= 999)
        {
            if (h > 0)
            {
                Console.Write(hundreds);
                if (t > 0 && e == 0)
                {
                    Console.Write(" and " + tenths);
                }
                else if (t > 0 && e > 0 && tt > 20)
                {
                    Console.Write(" and " + tenths + " " + digits);
                }
                else if (t > 0 && e > 0 && tt > 10 && tt < 20)
                {
                    Console.Write(" and " + teens);
                }
                else if (t == 0 && e > 0)
                {
                    Console.Write(" and " + digits);
                }
            }
            else
            {
                if (t > 0 && e == 0)
                {
                    Console.Write(tenths);
                }
                else if (t > 0 && e > 0 && tt > 20)
                {
                    Console.Write(tenths + " " + digits);
                }
                else if (t > 0 && e > 0 && tt > 10 && tt < 20)
                {
                    Console.Write(teens);
                }
                else if (t == 0 && e >= 0)
                {
                    Console.Write(digits);
                }
            }
            Console.WriteLine();
        }
    }
}