/*  Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.*/

using System;
//using System.Diagnostics;
class AllocateArray
{
    static void Main()
    {
        //Stopwatch sw = new Stopwatch();
        //sw.Start();

        int[] intNums = new int[20];
        for (int i = 0; i < 20; i++)
        {
            intNums[i] = 5 * i;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Element {0} has value {1}", i, intNums[i]);
        }

        //Process currProcess = Process.GetCurrentProcess();
        //long memoryUsed = currProcess.PrivateMemorySize64;
        //Console.WriteLine((double)memoryUsed / 1024d);
        //sw.Stop();
        //Console.WriteLine((double)sw.ElapsedMilliseconds / 1000d);



    }
}
