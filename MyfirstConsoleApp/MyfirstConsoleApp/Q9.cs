using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q9
    {

        static public void Sol8()
        {   
            int prev = 0;
            int prev2 = 1;
            Console.WriteLine(prev);
            Console.WriteLine(prev2);
            int sum = prev + prev2;
            while(sum<=40)
            {
                Console.WriteLine(sum);
                prev = prev2;
                prev2 = sum;
                sum=prev+ prev2;
            }
            
        }
    }
}
