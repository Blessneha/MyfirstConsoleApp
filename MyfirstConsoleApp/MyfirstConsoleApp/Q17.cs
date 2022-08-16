using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q17
    {
        static public void Sol16()
        {
            Console.WriteLine("Enter a word:");
            string word1=Console.ReadLine();
            char[] arr=word1.ToCharArray();
            for(int i=0;i<arr.Length/2;i++)
            {
                char c=arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = c;

            }
            string s = new string(arr);
            Console.WriteLine("Reversed string: "+s);
        }
    }
}
