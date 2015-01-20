/* Declare two string variables and assign them with Hello and World.
   Declare an object variable and assign it with the concatenation of the first two variables.
   Declare a third string variable and initialize it with the value of the object variable. */


using System;
class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object firstPlusSecond = firstString + " " + secondString;
        string thirdString = (string)firstPlusSecond;
        Console.WriteLine(thirdString);

    }
}

