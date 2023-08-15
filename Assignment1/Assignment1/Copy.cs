using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Copy
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] arr1 =new int[10];
            int[] arr2 = new int[10];
            //
            Console.WriteLine("Enter the no of elements in the array:");
            n = Convert.ToInt32(Console.ReadLine());
            //
            Console.WriteLine("Input {0} elements in the array \n", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element :", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {

                arr2[i] = arr1[i];
            }
            //Now Printing
            Console.WriteLine("The elements in the first array are:");
            for(i = 0; i < n;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("The elements in the second array are:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr2[i]);
            }

        }
    }
}

