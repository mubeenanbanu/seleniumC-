using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class Palindrome
    {
        public void Method1()
        {
            Console.WriteLine("enter a number to find palindrome");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0; int sum = 0;
            int temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine("given no is palindrome");
            }
            else
            {
                Console.WriteLine("given no is not a palindrome");
            }
        }

    }
}
