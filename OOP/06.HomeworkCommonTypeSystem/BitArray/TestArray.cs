
namespace BitArray
{
    using System;
    class TestArray
    {
        static void Main(string[] args)
        {
            BitArray arr = new BitArray(1111u);
            BitArray arr2 = new BitArray(33333u);

            Console.WriteLine(arr);
            arr[1] = 0;
            Console.WriteLine(arr);

            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);
        }
    }
}
