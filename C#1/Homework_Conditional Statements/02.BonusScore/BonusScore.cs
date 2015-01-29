/* Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.*/

using System;
class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter score in range [0...9]: ");
        int score = sbyte.Parse(Console.ReadLine());
        int bonusScore;
        if (score>=1&&score<=3)
        {
            bonusScore = score * 10;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
        else if (score>=4&&score<=6)
        {
            bonusScore = score * 100;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
        else if (score>=7&&score<=9)
        {
            bonusScore = score * 1000;
            Console.WriteLine("The result is: {0}", bonusScore);
        }
        else if (score<1||score>9)
        {
            Console.WriteLine("Invalid score");
        }
        
    }
}