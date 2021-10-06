using System;

namespace Arrays
{
    class array1
    {
        static void Main(string[] args)
        {
            //print 10 elements of array
          //  int[] arr = { 12, 2, 345, 67, 234, 890, 12, 34, 45, 678 };
            int[] arr = new int[10] { 12, 2, 345, 67, 234, 890, 12, 34, 45, 678 };  //way to initialise array
            Console.WriteLine("The array is:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //accept and print 5 elements of an array
            int[] arr1 = new int[5];
            Console.WriteLine("Enter 5 elements of array:");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("The array with 5 elements accepted is:");
        //    for (int i = 0; i < 5; i++)
         //   {
        //        Console.WriteLine(arr1[i]);
        //    }

            //using foreach
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
