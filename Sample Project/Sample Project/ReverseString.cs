using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class ReverseString
    {
        public void Method1()
        {
            Console.WriteLine("enter a string to reverse");
            string str = Console.ReadLine();
            string revstr = "";
            for (int i = str.Length-1; i >-1 ; i--)
            {
               
                    revstr += str[i];
  
            }
            Console.WriteLine(revstr);
        }
    }
}
