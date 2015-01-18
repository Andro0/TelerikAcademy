//Program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;
class Number10Sequence
{
    static void Main()
    {
        int seqNum = 0;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                seqNum = i;
            }
            else
            {
                seqNum = i * (-1);
            }

            Console.Write(seqNum + ", ");

        }
    }
}

