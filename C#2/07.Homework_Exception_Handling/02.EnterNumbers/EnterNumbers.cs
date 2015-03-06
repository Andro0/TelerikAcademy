/*  Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;
using System.IO;
    class EnterNumbers
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            byte count = 0;
            int previousNumber = 0;

            while (count < 10)
            {
                try
                {
                    int nexNumber = ReadNumber(start, end);
                    if (previousNumber >= nexNumber)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    previousNumber = nexNumber;
                    count++;
                }
                catch (ArgumentOutOfRangeException smallNumber)
                {
                    Console.WriteLine(smallNumber.Message);
                }
            }

        }

        static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                string input = Console.ReadLine();
                number = int.Parse(input);
                if ((number < start) || (number > end))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (OutOfMemoryException outOfMemory)
            {
                Console.WriteLine(outOfMemory.Message);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }
            catch (ArgumentNullException nullExeption)
            {
                Console.WriteLine(nullExeption.Message);
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
            }
            catch (OverflowException overflow)
            {
                Console.WriteLine(overflow.Message);
            }
            catch (IOException IO)
            {
                Console.WriteLine(IO.Message);
            }
            catch (Exception general)
            {
                Console.WriteLine(general.Message);
            }

            return number;
        }

    }
