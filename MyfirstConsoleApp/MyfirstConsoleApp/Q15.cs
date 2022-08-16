using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q15
    {
        static public void Sol14()
        {
            int tot = 0;
            int avg = 0;
            int maxi = int.MinValue;
            int mini = int.MaxValue;
            int[] arr = new int[10];
            for(int i=0;i<10;i++)
            {
                
                int num=Convert.ToInt32(Console.ReadLine());
                arr[i]=num;
                tot += num;
                maxi = Math.Max(maxi, num);
                mini= Math.Min(mini, num);

            }
            avg = tot / 10;

            Console.WriteLine("Total marks is: " +tot);
            Console.WriteLine("Average marks is: " +avg);
            Console.WriteLine("Minimum mark is: " +mini);
            Console.WriteLine("Maximum mark is: " +maxi);
            //printing in ascending order
            Array.Sort(arr);
            Console.Write("The ascending numbers are: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+"  ");
            }
            //printing in descending order
            Console.Write("\nThe descending numbers are: ");
            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.Write(arr[i]+"  ");
            }


        }
    }
}
