using System;
using A;
namespace Sample_Project
{
    public class Program:Class2
    {
        readonly int r1 = 09;
        readonly string r2 = "mubeena";
        //public Program(int a,string b)
        //{
        //    r1 = a;
        //    r2 = b;

        //}
        public enum JobCode
        {
            winter,
            summer
        


        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string str = "678";
            //int i = Convert.ToInt32(str);
            //Console.WriteLine(i);

            //double a = 9089900.0000;

            //float a1 = Convert.ToInt64(a);


            
            //string str1 =Convert.ToString( a);

            //Char c = 'A';
            //string s2 = Convert.ToString(c);

            //bool b = true;
            //string s1 =Convert.ToString (b);

            //Console.WriteLine(a1+" "+str1+" "+s1+" "+s2);

            //Program pg = new Program(56, "mk");
            //Console.WriteLine(pg.r2);

            // int  b1 = 90;
            //int b2 = 80;
            //Meth1(ref b1,ref b2);

            //Console.WriteLine( b1 +" "+b2);
            int sw = 10;
            switch(sw)
            {
                case 10:
                    Console.WriteLine(10);
                    break;
                case 20:
                    Console.WriteLine(20);
                    break;
                default:
                    break;


            }
          
            while(sw>0)
            {
                Console.WriteLine(sw);
                sw--;
            }


            // int c1 = 90;
            //Meth2(out c1);
            // Console.WriteLine(c1);
            Console.WriteLine("----------------------");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    if (i == 2 && j == 3)
                    {
                        continue;
                    }
                    Console.WriteLine(i + " " + j);
                }


            }

            //ineligible:
            //    Console.WriteLine("ineligible");
            
            //Console.WriteLine("enter a age");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n<5)
            //{
            //    goto ineligible;
            //}
            //else
            //{
            //    Console.WriteLine("not ");
            //}
            int[] arr = { 12, 13 };
            int[] arr1 = new int[2];
            arr1[0] = 9;
            arr1[1] = 98;
            int[] arr2 = new int[] { 56, 87 };

            Console.WriteLine("_____________--");
            Customer c = new Customer("mubeena", "banu");
            Customer c1 = new Customer("78");
            Customer.Method1();
            Customer c2 = new Customer("90","kl");
            c2.PrintFullName();

            Console.WriteLine(Customer.count);

            Console.WriteLine("------------");
            Console.WriteLine(Circle.Area());

            Address a = new Address("shimoga", "kamth bagh");
           a.Add(2, 3); 
            Employee e = new Employee("mubina",a);
            
           e.DisplayName();
            Programmer p = new Programmer("mubbi", a, 34.78f);

            Shape  r = new Rectangle();
            r.Draw();

            Class1 cp = new Class1();//public 
            Console.WriteLine(cp.name);
            cp.Msg();

            Program p2 = new Program();
            p2.Display();

            Factorial f = new Factorial();
            f.method1();
            Console.WriteLine("-----");
            // CountNoInCharacters ch = new CountNoInCharacters();
            //ch.Method1();
            




        }
        public static void Meth1(ref int b,ref int c)
        {

            c = c + 30;
            b = b + 10;
            

        }
        public static void  Meth2(out int b)
        {
             b = 10;
            b = b + 100;

           
        }
        

    }
    public class Customer
    {
        string firstName;
        string lastName;
        string id;
        public static int count = 0;
        static Customer()
        {
            count++;
        }
        public Customer(string id):this("no first name","no last name")
        {
            this.id = id;
            count++;
        }
        public Customer(string fname,string lname)
        {
            firstName = fname;
            lastName = lname;
            count++;
        }
        public  virtual void PrintFullName()
        {
            Console.WriteLine("Full Name:={0}" ,this.firstName +" "+this.lastName+this.id);
           
        }
        public static void Method1()
        {
            Console.WriteLine("hi"+Customer.count);
        }
    }
    public static class Circle
    {
        public static float PI = 3.14f;
        public   static float Area()
        {
            return PI * 2;
        }
        static Circle()
        {
            PI++;
        }
    }
    public class RegCustomer:Customer
    {
        public RegCustomer(string a ,string b):base (a,b)
        {

        }

    }
     public class Employee
    {
        private string name;
        public  string Name { get; }
        public Address address;

        public Employee(string name,Address address)
        {
            this.name = name;
            this.address = address;
        }
        public void DisplayName()
        {
            Console.WriteLine("Name :"+name+ " lives in "+ address.City);
        }
       public virtual  void Dresswell()
        {
            Console.WriteLine("dress");
        }
    }
    public class Address
    {
        private string city;
        public string City { get; set; }

        public string street;
        public int a;public int b;public int c;
        public Address(string c,string s)
        {
            City = c;
            street = s;
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public void  Add(int a ,int b,int c)
        {
            Console.WriteLine(a+b);
        }

    }
    public class Programmer : Employee
    {
        private float bonus;
        public float Bonus { get; set; }
        public Programmer(string n, Address a, float b) : base(n, a)
        {
            bonus = b;
            Console.WriteLine(base.address.street);
        }
        public sealed override void Dresswell()
        {

        }
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Rectangle : Shape,Eat,Drink
    {
        public override void Draw()
        {
            Console.WriteLine("draw");
        }

        public void Drinking()
        {
            Console.WriteLine("drinking in rectangle class");
        }

        public void Markline()
        {
            Console.WriteLine("markline in rectangle");
        }
    }

    public interface  Eat
    {
        void Markline();
    }
    public interface Drink
    {
        void Drinking();
    }








}


