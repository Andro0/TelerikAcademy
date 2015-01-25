/*  We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the 
value v at the position p from the binary representation of n while preserving all other bits in n. */

using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer n from where to modify:");
        int intNum = int.Parse(Console.ReadLine());
        Console.Write("Enter index p:");
        int intP = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value (0 or 1):");
        byte bitValue = byte.Parse(Console.ReadLine());

        int mask = 1 << intP;
        int modifiedNum;

        if (bitValue == 1)
        {
            modifiedNum = intNum | mask;
        }
        else
        {
            modifiedNum = intNum & (~mask);
        }

        int intNumAndMask = intNum & mask;
        int bitP = intNumAndMask >> intP;

        Console.WriteLine("\n" + "Number".PadRight(10) + "Binary representation".PadRight(19) +
            "p".PadLeft(4) + "v".PadLeft(4) + "Binary result".PadLeft(19) + "Result".PadLeft(10));

        Console.WriteLine(Convert.ToString(intNum).PadRight(12) +
            Convert.ToString(intNum, 2).PadLeft(16, '0') + Convert.ToString(intP).PadLeft(7) +
            Convert.ToString(bitValue).PadLeft(4) + "    " + Convert.ToString(modifiedNum, 2).PadLeft(16, '0') +
               Convert.ToString(modifiedNum).PadLeft(8));

    }
}