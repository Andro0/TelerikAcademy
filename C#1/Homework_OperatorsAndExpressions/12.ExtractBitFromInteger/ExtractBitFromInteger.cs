//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBitFromInteger
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
            "Index p".PadRight(8)+"Bit @ p".PadLeft(8));

        Console.WriteLine(Convert.ToString(intNum).PadRight(15) +
            Convert.ToString(intNum, 2).PadLeft(32, '0') + Convert.ToString(intP).PadLeft(8)+
            Convert.ToString(bitP).PadLeft(8));




    }
}
