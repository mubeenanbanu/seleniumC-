using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //ConvertNoToCharacters c = new ConvertNoToCharacters();
            //c.Method1();
            //ForLoops f = new ForLoops();
            //f.PrintNumbers();

            //CompareTwoDates c = new CompareTwoDates();
            //c.Method1();

            Class1 c = new Class1();
            //c.Arrays();
            //c.CheckDigitInString();

            //c.PrintStarInSquare();

           // c.PrintStarInCross();

            //Palindrome p = new Palindrome();
            //p.Method1();

            //ReverseStringwithfunction r = new ReverseStringwithfunction();
            //r.Method1();

            //Removeduplicate rd = new Removeduplicate();
            //rd.Method1();
            SortArray s = new SortArray();
            s.WithoutFunction();
        }
        public void Arrays()
        {
            string[] arr = { "mubeena", "banu", "sanobar", "mahin" };
            var f = Array.FindIndex(arr, e => e.Equals("banu"));
            Console.WriteLine(f);

            var g = Array.FindAll(arr, e => e.StartsWith("m"));
            foreach (var i in g)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(string.Join("\n" ,g));

            var b = Array.FindLast(arr, e => e.Contains("a"));
            Console.WriteLine(b);


            Console.WriteLine("_____--------");
            //sort
            Array.Sort(arr, 0, 2);
           // Array.Sort(arr);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            //to find no / 5 in array
            int[] a1 = { 90, 87, 65, 23 };
            Console.WriteLine(Array.Exists(a1, (e => e % 5 == 0)));
            var a=Array.FindAll(a1,(a=>a%5==0));
            Console.WriteLine(string.Join("\n",a));




        }
        public void CheckDigitInString()
        {
            String s = "mubeena";
            String s1 = "122bahwkd9";
            Console.WriteLine(Char.IsDigit(s, 0)) ;
            Console.WriteLine(char.IsLetterOrDigit(s1[9]));

        }

        public void PrintStarInSquare()
        {
            int Size;

            Console.WriteLine("Enter the size of the square: ");
            Size = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < Size; row++)
            {
                for (int column = 0; column < Size; column++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
            }
        }
        public void PrintStarInCross()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write("*"+" ");
                }
            }
        }
    }
}
