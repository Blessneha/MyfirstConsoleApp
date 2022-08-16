using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q11
    {
        static public void Sol10()
        {
            Console.WriteLine("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine($"{num}*{i} ={num*i}");
            }

        }
    }
}
