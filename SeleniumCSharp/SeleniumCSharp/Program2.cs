//Global scope of main
using System;
using System.Collections;

Console.WriteLine("hi my name is mubina");

//String[][] array = new String[3, 4];
//array[0][0] = "Mubina";
//array[3][3] = "Banu";

//for (int i = 0; i < array.Length; i++)
//{
//    for(int j=0;j<array.Length;j++)
//    {
//        Console.WriteLine(array[i][j]);
//    }
//}
String[] ar = { "mubina", "banu" ,"4546","john"};
int[] arr1 = new int[2];

arr1[0] = 90;
arr1[1] = 80;
Console.WriteLine(arr1[1]);
Console.WriteLine(ar[0]);
Console.WriteLine("--------------------");
foreach( string i in ar)
{
    Console.WriteLine(i);
    if(i=="4546")
    {
        Console.WriteLine("match found");
        break;
    }
}
Console.WriteLine("--------------------");

for (int i = 0;i< arr1.Length;i++)
{
    Console.WriteLine(arr1[i]);
}

ArrayList a = new ArrayList();
a.Add("john");
a.Add("mubina");
a.Add("a");

for (int i = 0; i < a.Count;i++)
 {
    Console.WriteLine(a[i]);

}
a.Sort();
Console.WriteLine("sort----------");
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);

}
a.Contains("mubina");
Console.WriteLine("reverse--------");
a.Reverse();
for (int i = 0; i < a.Count; i++)
{
    Console.WriteLine(a[i]);

}
//Program p = new Program();
//p.GetData();