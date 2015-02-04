/*  Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.*/

using System;
    class HexToDecimal
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal number:");
            string hexNum = Console.ReadLine();

            long decimalNum = 0;
            int last = hexNum.Length - 1;

            for (int i = 0; i < hexNum.Length; i++, last--)
            {
                int num;
                switch (hexNum[i])
                {
                    case 'A': num = 10;
                        break;
                    case 'B': num = 11;
                        break;
                    case 'C': num = 12;
                        break;
                    case 'D': num = 13;
                        break;
                    case 'E': num = 14;
                        break;
                    case 'F': num = 15;
                        break;
                    default: num = int.Parse(hexNum[i].ToString());
                        break;
                }
                long hexSum = 1;
                for (int j = 0; j < last; j++)
                {
                    hexSum *= 16;
                }
                hexSum *= num;
                decimalNum += hexSum;
            }
            Console.WriteLine("The decimal value is: {0}",decimalNum);
        }
    }
