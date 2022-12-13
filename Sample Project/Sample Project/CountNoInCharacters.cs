using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class ConvertNoToCharacters
    {
        public void Method1()
        {
            Console.WriteLine("enter a number to convert");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem = 0,r=0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            n = sum;
            while(n>0)
            {
                rem= n % 10;
                switch(rem)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                    case 0:
                        Console.Write("zero");
                        break;
                    default:
                        Console.Write("tttt");
                        break;

                }
                Console.Write(" ");
                n = n / 10;
            }
            Console.WriteLine("\nConverted Numbers into characters");

        }
    }
}
