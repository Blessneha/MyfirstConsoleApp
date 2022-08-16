using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q6
    {
        static public void Sol5()
        {
            int f;
            int c;
            Console.WriteLine("Enter the degree in Farenheit");
            f=Convert.ToInt32(Console.ReadLine());
            c = ((f - 32) * 5) / 9;
            Console.WriteLine("Celcius: " +c);


        }
    }
}
