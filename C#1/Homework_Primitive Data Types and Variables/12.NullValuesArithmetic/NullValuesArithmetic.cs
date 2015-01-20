/*  Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result. */

using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? intNullValue = null;
        double? doubleNullValue = null;
        Console.WriteLine("This is the integer with Null value: " + intNullValue);
        Console.WriteLine("This is the real number with Null value: " + doubleNullValue);

        intNullValue += 100;
        Console.WriteLine("This is the null added with integer value: " + intNullValue);

        doubleNullValue += 123.45;
        Console.WriteLine("This is the null added with real number value: " + doubleNullValue);

    }
}

