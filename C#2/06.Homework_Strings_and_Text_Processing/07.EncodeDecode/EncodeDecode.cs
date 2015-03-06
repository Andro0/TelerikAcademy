/*  Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first
    letter of the string with the first of the key, the second – with the second, etc. 
    When the last key character is reached, the next is the first.
 */

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter cypher:");
        string key = Console.ReadLine();
        Console.Write("Enter text:");
        string text = Console.ReadLine();

        string encode = EncodeDecodeString(key, text);
        string decode = EncodeDecodeString(key, encode);
        Console.WriteLine("Encoded text is:{0}\nDecoded text is:{1}", encode, decode);
    }

    private static string EncodeDecodeString(string cypher, string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            sb.Append((char)((ushort)text[i] ^ (ushort)cypher[i % cypher.Length]));
        }
        return sb.ToString();
    }
}