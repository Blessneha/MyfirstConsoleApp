using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstConsoleApp
{
    internal class Q19
    {
        static public void Sol18()
        {
            Console.WriteLine("Enter a word:");
            string s=Console.ReadLine();
            char[] prr=s.ToCharArray();
            for(int i=0; i<prr.Length/2; i++)
            {
                char tem=prr[i];
                prr[i] = prr[prr.Length-i-1];
                prr[prr.Length - i - 1]=tem;
            }

            string p=new string(prr);
            if(p==s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
