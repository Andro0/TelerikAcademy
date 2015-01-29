/* Classical play cards use the following signs to designate the card face:
   `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a
   string and prints “yes” if it is a valid card sign or “no” otherwise.*/


using System;
class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter string to check if it is a valid card sign:");
        string card = Console.ReadLine();
        string[] cardSigns = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "j", "Q", "q", "K", "k", "A", "a" };
        bool isSign = false;
        for (int i = 0; i < cardSigns.Length; i++)
        {
            if (card == cardSigns[i])
            {
                isSign = true;
            }
        }
        Console.WriteLine("Is your card a valid card sign? --->{0}",isSign);
    }
}