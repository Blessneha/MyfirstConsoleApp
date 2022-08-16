using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q3
    {
        static public void Sol2()
        {
            int n, r;
            Console.WriteLine("Enter two numbers: ");
            n=Convert.ToInt32(Console.ReadLine());
            r=Convert.ToInt32(Console.ReadLine());
            for(int i=n+1;i<r;i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
