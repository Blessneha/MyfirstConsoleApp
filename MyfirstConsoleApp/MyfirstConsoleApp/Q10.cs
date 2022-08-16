using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q10
    {
       static public void Sol9()
        {   double sum=0;
            Console.WriteLine("Enter a number: ");
            double n= Convert.ToDouble(Console.ReadLine());
            for (int i=5;i<=n;i++)
            {
                sum += Math.Pow(i, 3);
            }
            Console.WriteLine(sum);
        }
        
    }
}
