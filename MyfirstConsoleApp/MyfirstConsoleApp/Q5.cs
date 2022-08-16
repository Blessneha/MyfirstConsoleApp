using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q5
    {
        static public void Sol4()
        {
            int odd = 0;
            int even = 0;
            Console.WriteLine("Enter the total number to add onto the array");
            int r=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[r];
            Console.WriteLine("Enter the values in array");
            for(int i=0;i<r;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<r;i++)
            {
                if(arr[i]%2==0)
                {
                    even++;

                }

                else
                {
                    odd++;
                }
            }

            Console.WriteLine("Number of even numbers are: " +even+ " and number of odd numbers are "+odd);

        }
    }
}
