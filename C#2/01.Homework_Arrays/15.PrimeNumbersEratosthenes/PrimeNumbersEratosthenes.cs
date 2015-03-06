//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbersEratosthenes
{
    static void Main()
    {
        int num = 100000; //100000 just to see it works!
        //num=10000000; // Uncomment to rut it for 10 million!!! Too long 
        bool[] flag = new bool[num];

        for (int i = 2; i < num; i++)
        {
            flag[i] = true;
        }

        for (int i = 2; i < num; i++)
        {
            if (flag[i] == true)
            {
                int j = i + 1;
                while (j < num)
                {
                    if (j % i == 0)
                    {
                        flag[j] = false;
                    }
                    j++;
                }
            }
        }

        for (int i = 2; i < num; i++)
        {
            if (flag[i] == true)
            {
                Console.Write("{0} ", i);
            }
        }
    }

}
