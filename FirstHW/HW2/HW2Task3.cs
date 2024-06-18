//Task 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHW.HW2
{
    internal class HW2Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, add 4 digits number: ");

            string a = Console.ReadLine();
            if (a.Length != 4)
            {
                Console.WriteLine("Add 4 digits number.");
            }
            else
            {
                if (!isPolindrome(a))
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }

            static bool isPolindrome(string number)
            {
                return number[0] == number[3] && number[1] == number[2];
            }
        }
    }
}
