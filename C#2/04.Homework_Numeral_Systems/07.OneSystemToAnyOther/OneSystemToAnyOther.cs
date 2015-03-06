/*  Write a program to convert from any numeral system of given base s to any other 
    numeral system of base d (2 ≤ s, d ≤ 16). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base of S numeral system S=");
        int sBase = int.Parse(Console.ReadLine());
        Console.Write("Enter base of D numeral system D=");
        int dBase = int.Parse(Console.ReadLine());
        Console.Write("Enter number in S numeral system N=");
        string sNum = Console.ReadLine();

        Console.WriteLine("{0}", SToD(sBase,dBase,sNum));

    }
    static string SToD(int sBase, int dBase, string sNum)
    {
        long sToDec = BaseToDec(sNum, sBase);
        string decToD = DecToBase(sToDec, dBase);
        return decToD;
    }

    static long BaseToDec(string sNum, int numeralSystem)
    {
        long decNumber = 0;
        for (int i = 0; i < sNum.Length; i++)
        {
            int digit = 0;
            if (sNum[i] >= '0' && sNum[i] <= '9')
            {
                digit = sNum[i] - '0';
            }
            else
            {
                digit = sNum[i] - 'A' + 10;
            }
            decNumber = decNumber + digit * (long)Math.Pow(numeralSystem, sNum.Length - i - 1);
        }

        return decNumber;
    }

    static string DecToBase(long number, int numeralSystem)
    {
        string result = "";

        while (number > 0)
        {
            long digit = number % numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            number /= numeralSystem;
        }
        return result;
    }
}
