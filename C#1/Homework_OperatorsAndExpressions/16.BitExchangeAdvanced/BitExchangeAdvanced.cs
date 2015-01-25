/*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits 
    {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap. */

using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter unsigned integer:");
        long unsignInt = long.Parse(Console.ReadLine());
        long input = unsignInt;
        Console.Write("Enter start exchange position (p):");
        int startExchangePosition = int.Parse(Console.ReadLine());
        Console.Write("Enter exchange position (q):");
        int exchangeFromPosition = int.Parse(Console.ReadLine());
        Console.Write("Enter number of bits to exchange (k):");
        int exchangeBits = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int firstSeqBits = 0;
        int secondSeqBits = 0;

        if ((startExchangePosition < 2) || (startExchangePosition > 31) ||
            (exchangeFromPosition < 2) || (exchangeFromPosition > 31) ||
            (exchangeBits > 16) || (exchangeBits < 1))
        {
            Console.WriteLine("Input number:{0}", unsignInt);
            Console.WriteLine("Start exchange position (p):{0}", startExchangePosition);
            Console.WriteLine("Exchange position (q):{0}", exchangeFromPosition);
            Console.WriteLine("Number of bits to exchange (k):{0}", exchangeBits);
            Console.WriteLine("----");
            Console.WriteLine("----");
            Console.WriteLine("Out of range");
        }

        else if ((int)Math.Abs(startExchangePosition - exchangeFromPosition) < exchangeBits)
        {
            Console.WriteLine("Input number:{0}", unsignInt);
            Console.WriteLine("Start exchange position (p):{0}", startExchangePosition);
            Console.WriteLine("Exchange position (q):{0}", exchangeFromPosition);
            Console.WriteLine("Number of bits to exchange (k):{0}", exchangeBits);
            Console.WriteLine("----");
            Console.WriteLine("----");
            Console.WriteLine("Overlapping");
        }
        else if ((int)Math.Abs(startExchangePosition - exchangeFromPosition) >= exchangeBits)
        {

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

            Console.WriteLine("Input number:{0}", unsignInt);
            Console.WriteLine("Start exchange position (p):{0}", startExchangePosition);
            Console.WriteLine("Exchange position (q):{0}", exchangeFromPosition);
            Console.WriteLine("Number of bits to exchange (k):{0}", exchangeBits);
            Console.WriteLine("Binary representation of input-------->:{0}", Convert.ToString(unsignInt, 2).PadLeft(32, '0'));
            Console.WriteLine("Binary representation of exchanged bits:{0}", Convert.ToString(input, 2).PadLeft(32, '0'));
            Console.WriteLine("New exchanged number:{0}", input);

        }
    }
}


