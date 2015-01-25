/*  Write a Boolean expression that returns if the bit at position p
 * (counting from 0, starting from the right) in given integer number n, has value of 1. */

using System;
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer n from where to extract:");
        int intNum = int.Parse(Console.ReadLine());
        Console.Write("Enter index p:");
        int intP = int.Parse(Console.ReadLine());

        int mask = 1 << intP;
        int intNumAndMask = intNum & mask;
        int bitP = intNumAndMask >> intP;

        Console.WriteLine("\n" + "Number".PadRight(15) + "Binary representation".PadRight(35) +
            "Index p".PadRight(8) + "Bit @ p == 1".PadLeft(15));

        Console.WriteLine(Convert.ToString(intNum).PadRight(15) +
            Convert.ToString(intNum, 2).PadLeft(32, '0') + Convert.ToString(intP).PadLeft(8) +
            ((bitP == 1) ? "true".PadLeft(15) : "false".PadLeft(15)));

    }
}