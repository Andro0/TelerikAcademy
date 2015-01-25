/*  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0. */

using System;
class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter unsigned integer:");
        uint unsignedInt = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint unIntAndMask = unsignedInt & mask;
        uint bitThree = unIntAndMask >> 3;

        Console.WriteLine("\n"+"Number".PadRight(15) + "Binary representation".PadRight(40) + "Bit #3".PadLeft(3));

        Console.WriteLine(Convert.ToString(unsignedInt).PadRight(15) + 
            Convert.ToString(unsignedInt, 2).PadLeft(32,'0') + Convert.ToString(bitThree).PadLeft(11));
    }
}
