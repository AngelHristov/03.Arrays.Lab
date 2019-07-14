using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[] 
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (number > 0 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
