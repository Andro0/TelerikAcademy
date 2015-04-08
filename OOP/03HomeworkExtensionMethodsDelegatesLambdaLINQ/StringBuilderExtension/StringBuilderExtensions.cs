/*Problem 1. StringBuilder.Substring
    Implement an extension method Substring(int index, int length) for 
    the class StringBuilder that returns new StringBuilder
    and has the same functionality as Substring in the class String.*/

namespace StringBuilderExtension
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder newString = new StringBuilder();
            int stopPoint;

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }
            else if (index >= str.Length)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be larger than length of string.");
            }
            else if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length cannot be less than zero.");
            }
            else
            {
                if (length == 0)
                {
                    stopPoint = str.Length;
                }
                else
                {
                    stopPoint = index + length;

                    if (stopPoint > str.Length)
                    {
                        throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
                    }
                }

                for (int i = index; i < stopPoint; i++)
                {
                    newString.Append(str[i]);
                }
            }

            return newString;

        }
    }
}
