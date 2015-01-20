/*Declare two integer variables a and b and assign them with 5 and 10
  and after that exchange their values by using some programming logic.
  Print the variable values before and after the exchange. */

using System;
class ExchangeVarValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Value of a before exchange is {0}", a);
        Console.WriteLine("Value of b before exchange is {0}", b);
        Console.WriteLine("".PadLeft(40, '-'));
        a = a - b; //a=-5
        b = a + b; //b=5
        a = b - a; //a=10
        Console.WriteLine("Value of a after exchange is {0}", a);
        Console.WriteLine("Value of b after exchange is {0}", b);
        Console.WriteLine("".PadLeft(40, '-'));

    }
}

