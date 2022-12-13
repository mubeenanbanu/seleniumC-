using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class ForLoops
    {
        /*print numbers in 
        *
        **
        *** 
        */
        public void PrintNumbers()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                
            }

            Console.WriteLine("-------------------");
            /* print
             ****
             ***
             **
             */
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=5-i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
