using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Delete
    {
        static void Main(string[] args)
        {
            int i, n, pos;
            int[] arr1 =new int[10];
            Console.WriteLine("Enter the size of the array:");
            n = Convert.ToInt32(Console.ReadLine());
            //
            Console.WriteLine("The Elements in the array are:", n);
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Elements:",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the position where you want to delete the item:");
            pos = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (i!=pos-1)
            
                i++;
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.WriteLine("The updated list is:");
            for(i = 0; i < n; i++) 
            {
                Console.WriteLine(arr1[i]);
                    }
                
            }
        }
    }

