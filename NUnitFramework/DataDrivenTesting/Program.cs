using CsharpFramework.Utilities;
using System;

namespace DataDrivenTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            JsonReader js = new JsonReader();
            js.extractData();
            Console.WriteLine("Hello World!");
        }
    }
}
