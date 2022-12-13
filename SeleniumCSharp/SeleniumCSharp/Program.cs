using System;
using System.Diagnostics;

namespace SeleniumCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String s = "mubeena";
            int count = 0;
            for (int i=0;i<s.Length;i++)
            {
                char c = s[i];
                count = 0;
                for (int j=0;j<s.Length;j++)
                {
                    
                    if (c==s[j])
                    {
                        count++;

                    }
                  

                }
                Console.WriteLine(c+" "+count);
            }
            System.Console.WriteLine("rahulshettyacademy.com!");

        }
    }
}
