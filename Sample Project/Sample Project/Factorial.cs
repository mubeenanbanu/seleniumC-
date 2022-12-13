using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class Factorial
    {
        public void method1()
        {
            Console.WriteLine("enter a no.");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for(int i=1;i<=n;i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
