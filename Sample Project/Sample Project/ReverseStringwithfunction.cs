using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class ReverseStringwithfunction
    {
        public void Method1()
        {
            string s = "mubeena";
            char[] c=s.ToCharArray();
            Array.Reverse(c);
            string n=new string(c);
            Console.WriteLine(n);
        }

    }
}
