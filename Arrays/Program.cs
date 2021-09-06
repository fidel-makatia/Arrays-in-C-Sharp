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


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Value; " + i + " is\t" + arr[i]);
            }



        }
    }
}
