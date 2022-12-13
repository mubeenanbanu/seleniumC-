using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class Removeduplicate
    {
        public void Method1()
        {
            Console.WriteLine("enter a string to remove duplicate");
            string str = Console.ReadLine();
            string newstring = "";
            for(int i=0;i<str.Length;i++)
            {
                if(!newstring.Contains(str[i]))
                {
                    newstring += str[i];
                }
            }
            Console.WriteLine("string after removing duplicates: " +newstring);

        }
    }
}
