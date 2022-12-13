using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Project
{
    public class SortArray
    {
        public void WithoutFunction()
        {
            int[] intArray =new int[] { 3, 9, 2, 4, 5, 1 };
            int temp = 0;
            for(int i=0;i< intArray.Length; i++)
            {
                for(int j=i+1;j<intArray.Length;j++)
                {
                    if(intArray[i]>intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array in ascending order");
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }
        }

    }
}
