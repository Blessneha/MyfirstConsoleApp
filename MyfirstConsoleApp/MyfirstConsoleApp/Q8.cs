using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q8
    {
        static public void Sol7()
        {
            int num;
            int prod = 1;
            num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                prod *= i;
            }
            Console.WriteLine("Factorial is "+prod);
            Console.ReadLine();
            
        }
    }
}
