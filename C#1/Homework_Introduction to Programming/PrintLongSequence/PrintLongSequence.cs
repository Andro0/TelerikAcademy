using System;
class PrintLongSequence
{
    static void Main()
    {
        int seqNum = 0;
        for (int i = 2; i < 1002; i++)
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
