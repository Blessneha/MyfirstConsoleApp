using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q14
    {
        static public void Sol13()
        {
            int r=int.MaxValue;
            Console.WriteLine("Enter 5 numbers: ");
            for(int i=0;i<5;i++)
            {
                int s=Convert.ToInt32(Console.ReadLine());
                r=Math.Min(r,s);
            }
            Console.WriteLine("Minimum value is: "+r);

        }
    }
}
