/*  Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.*/

using System;
    class SayHello
    {
        static void Main()
        {
            UserName();
        }
        static void UserName()
        {
            Console.Write("Enter your user name:");
            string user = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",user);
        }
    }
