using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] arr = new int[5];

            Console.WriteLine("Enter values");


            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered values");


            foreach(int i in arr)
            {
                Console.WriteLine("Value; \t" + i );
            }

           int n= Array.IndexOf(arr, 4,2);// searching values in leaner seach

            int p = Array.BinarySearch(arr, 4);// requires a sorted array

            Console.WriteLine("Value is at  \t" +n);

        }
    }
}
