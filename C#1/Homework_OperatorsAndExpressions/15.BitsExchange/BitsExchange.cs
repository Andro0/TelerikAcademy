//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter unsigned integer:");
        int unsignInt = int.Parse(Console.ReadLine());

        int input = unsignInt;
        int startExchangePosition = 3;
        int exchangeBits = 3;
        int exchangeFromPosition = 24;

        int firstSeqBits = 0;
        int secondSeqBits = 0;
        for (int i = 0; i < exchangeBits; i++)
        {
            if (0 != (input & (1 << (startExchangePosition + i))))
            {
                firstSeqBits |= (1 << i);
            }

            input &= ~(1 << startExchangePosition + i);

            if (0 != (input & (1 << (exchangeFromPosition + i))))
            {
                secondSeqBits |= (1 << i);
            }

            input &= ~(1 << exchangeFromPosition + i);
        }

        
        input |= secondSeqBits << startExchangePosition;
        input |= firstSeqBits << exchangeFromPosition;


        
        Console.WriteLine("Input number:{0}",unsignInt);
        Console.WriteLine("Binary representation of input-------->:{0}", Convert.ToString(unsignInt, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary representation of exchanged bits:{0}",Convert.ToString(input, 2).PadLeft(32, '0'));
               
        Console.WriteLine("New exchanged number:{0}",input);



    }
}