using System;

using ClassLibrary1;

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

            Array.Sort(arr);// sort in ascending order

            Console.WriteLine("Value is at  \t" +p);

            Array.Clear(arr, 3, 2);  //set to zero
            Array.Resize(ref arr, 7);//resize

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(arr); //reverse order

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // index from end operator

/*            int[] results = arr[^0];

            Console.WriteLine(results);
*/
            //range operator

            int[] results2 = arr[2..5];

            foreach(var item in results2)
            {
                Console.WriteLine(item);
            }

            //jagged arrays

            int[][] Arr_= new int[5][];

            Arr_[0] = new int[6];

            // Multi dimensional arrays

            int[,] rr = new int[3,9];
            //Array of Objects

            Employee emp = new Employee() { name = "FIFI", age = 34, ID = 1 };
            Employee emp1 = new Employee() { name = "FII", age = 32, ID = 2 };
            Employee emp2 = new Employee() { name = "FIFIzo", age = 12, ID = 3 };

            // array

            Employee[] employees = new Employee[] { emp, emp1, emp2 };

        }
    }
}
