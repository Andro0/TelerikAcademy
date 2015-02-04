/*  Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
    The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
    Use 2 nested for-loops and a switch-case statement.*/

using System;
class DeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (int card = 2; card <= 14; card++)
        {
            switch (card)
            {
                case 11:
                    {
                        Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}", 'J',
                            (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine(); break;
                    }
                case 12:
                    {
                        Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}", 'Q'
                            , (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine(); break;
                    }
                case 13:
                    {
                        Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}", 'K',
                            (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine(); break;
                    }
                case 14:
                    {
                        Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}", 'A',
                            (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine(); break;
                    }
                default:
                    {
                        Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}",
                            card, (char)6, (char)5, (char)4, (char)3);
                        Console.WriteLine(); break;
                    }
            }

        }
    }
}


