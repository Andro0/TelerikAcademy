//Program that prints the entire ASCII table of characters on the console

using System;
class PrintAsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Decimal".PadRight(17));
        Console.Write("ASCII".PadRight(18));
        Console.Write("Hex".PadRight(17));
        Console.WriteLine("\n");
        Console.WriteLine("".PadLeft(43, '-'));

        for (byte index = 0; index < byte.MaxValue; index++)
        {
            byte[] byteArray = { index };
            char[] asciiArray = System.Text.Encoding.GetEncoding(437).GetChars(byteArray);
            char asciiSign = asciiArray[0];

            switch (index)
            {
                case 0: Console.Write("{0} = not visible (null)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 7: Console.Write(@"{0} = not visible (""beep!"" sound)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 8: Console.Write("{0} = not visible (backspace)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 9: Console.Write("{0} = not visible (horizontal tab)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 10: Console.Write("{0} = not visible (new line)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 13: Console.Write("{0} = not visible (carriage return)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 127: Console.Write("{0} = not visible (DEL)".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                case 32: Console.Write("{0} = space".PadRight(38), index); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
                default: Console.Write("{0} =".PadRight(20), index); Console.Write("{0}".PadRight(20), asciiSign); Console.WriteLine(index.ToString("X2").PadRight(20)); break;
            }
        }
        Console.Write("{0} = not visible".PadRight(38), 255);
        Console.WriteLine("{0:X} ".PadRight(20), 255);

    }
}
