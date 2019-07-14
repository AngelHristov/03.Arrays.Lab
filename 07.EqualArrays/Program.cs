using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumOfArray = 0;
            bool areIdentical = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sumOfArray+= firstArray[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areIdentical = false;
                    break;
                }
            }
            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
            }
        }
    }
}
