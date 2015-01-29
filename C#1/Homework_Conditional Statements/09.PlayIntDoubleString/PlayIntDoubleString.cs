/*  Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/


using System;
class PlayIntDoubleString
{
    static void Main()
    {
        string shoose = @"Please choose a type:	
1 --> int	
2 --> double	
3 --> string";
        Console.WriteLine(shoose);
        string chosenType = Console.ReadLine();

        switch (chosenType)
        {
            case "1":
                {
                    Console.WriteLine("Please enter an int:");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result is:{0}", intNum + 1);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Please enter a double:");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is:{0}", doubleNum + 1);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Please enter a string:");
                    string str = Console.ReadLine();
                    Console.WriteLine("Result is:{0}", str+"*");
                    break;
                }
            default: Console.WriteLine("You choose incorect type!!!"); break;
        }
        
    }
}
