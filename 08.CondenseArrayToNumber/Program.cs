using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            while (array.Length > 1)
            {
                int[] condensedArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int index = array[i] + array[i + 1];
                    condensedArray[i] = index;
                }
                array = condensedArray;
            }
            Console.WriteLine(array[0]);
        }
    }
}
