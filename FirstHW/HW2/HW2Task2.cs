/* //Task 2
 * using System;
using System.Collections.Generic;

namespace FirstHW
{
    internal class HW2Task2
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 43, 4, 5, 6 };
            double result = minMaxAverage(num);
            Console.WriteLine("The average of the max and min numbers is: " + result);
        }

        static double minMaxAverage(List<int> numbers)
        {
            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            return (min + max) / 2.0;
        }
    }
}
*/