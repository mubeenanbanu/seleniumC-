using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class CompareTwoDates
    {
        public void Method1()
        {
            Console.WriteLine("enter a year");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a month");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a date");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second year");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second month");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second date");
            int d1 = Convert.ToInt32(Console.ReadLine());

            DateTime dt = new DateTime(y, m, d);
            DateTime dt1 = new DateTime(y1, m1, d1);
            if(dt1>dt)
            {
                Console.WriteLine($" {dt} is before {dt1} ");
            }
            else
            {
                Console.WriteLine($" {dt1} is before {dt} ");
            }

        }
    }
}
