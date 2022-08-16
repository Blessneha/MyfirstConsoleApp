using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q13
    {
        static public void Sol12()
        {
            Console.WriteLine("Enter three numbers:");
            int first=Convert.ToInt32(Console.ReadLine());
            int second=Convert.ToInt32(Console.ReadLine());
            int third=Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine($"{first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"{second} is the largest");
            }
            else if (third > first && third > second)
            {
                Console.WriteLine($"{third} is the largest");
            }
            else
            {
                Console.WriteLine("all are equal");
            }
        }
    }
}
