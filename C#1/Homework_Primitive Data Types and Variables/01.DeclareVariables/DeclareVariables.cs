/*Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000 */
using System;
class DeclareVariables
{
    static void Main()
    {
        ushort numUShort = 52130;
        sbyte numSByte = -115;
        int numInt = 4825932;
        byte numByte = 97;
        short numShort = -10000;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", numUShort, numSByte, numInt, numByte, numShort);

    }
}

