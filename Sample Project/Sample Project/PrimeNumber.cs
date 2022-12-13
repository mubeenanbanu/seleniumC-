using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class PrimeNumber
    {
        public void Method1()
        {
            Console.WriteLine("enter a number to find prime");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("no. is prime");
            }
            else
            {
                Console.WriteLine("no. is not prime");
            }
        }
    }
}
