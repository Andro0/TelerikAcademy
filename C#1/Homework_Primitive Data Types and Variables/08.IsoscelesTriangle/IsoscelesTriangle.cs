/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©   */

using System;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("   \u00A9\n\n");
        Console.Write("  \u00A9 \u00A9\n\n");
        Console.Write(" \u00A9   \u00A9\n\n");
        Console.Write("{0} {0} {0} {0}\n", '\u00A9');
        
    }
}

