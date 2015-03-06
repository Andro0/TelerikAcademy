/*  Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddingPolynomials
{
    static void Main()
    {
         Console.WriteLine("Enter coefficients for first polynomial on a single line separated by space:");
        int[] polynomialA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter coefficients for second polynomial on a single line separated by space:");
        int[] polynomialB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine();
        Console.WriteLine("Coefficients of result after addition:");
        Console.WriteLine(string.Join(" ", AddPolynomials(polynomialA, polynomialB)));

        //Console.WriteLine();
        //Console.WriteLine("Coefficients of result after substraction:");
        //Console.WriteLine(string.Join(" ", SubtractPolynomials(polynomialA, polynomialB)));
    }

    static int[] AddPolynomials(int[] polynomialA, int[] polynomialB)
    {
        int[] result = new int[polynomialA.Length];
        for (int i = 0; i < polynomialA.Length; i++)
        {
            result[i] = polynomialA[i] + polynomialB[i];
        }
        return result;
    }
    //static int[] SubtractPolynomials(int[] polynomialA, int[] polynomialB)
    //{
    //    int[] result = new int[polynomialA.Length];
    //    for (int i = 0; i < polynomialA.Length; i++)
    //    {
    //        result[i] = polynomialA[i] - polynomialB[i];
    //    }
    //    return result;
    //}

   
}