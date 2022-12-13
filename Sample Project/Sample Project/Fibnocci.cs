using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class Fibnocci
    {
        public void Method1()
        {
            Console.WriteLine("enter a number to find fibnocci");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;
            int n3 = 0;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 1; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
    }
    
}
namespace A
{
    class Class1
    {
        internal string name="mubina";
        internal void Msg()
        {
            Console.WriteLine("msg");
        }
    }
     public class Class2
    {
        protected string name;
        protected void Display()
        {

        }
    }
    public class Class3:Class2
    {
        Class2 ch = new Class2();
        
        
    }
    //Sample_Project.Fibnocci f1 = new Sample_Project.Fibnocci();
}
