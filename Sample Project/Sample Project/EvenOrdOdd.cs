using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class EvenOrdOdd
    {
        public void Evenorodd1()
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }

        }
        public void Fibnocci()
        {
            Console.WriteLine("enter a no.");
            int n=Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;
            Console.Write(n1 + " " + n2);
            int i = 0;
            int n3 = 0;
            while(i<n)
            {
                i++;
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
