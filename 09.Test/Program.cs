using System;

namespace _09.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2 };

            array1 = array2;
            array2[1] = 5;

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
