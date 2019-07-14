using System;

namespace _02.PrintNumbersReversed
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers); 
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
