using System.Transactions;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[100];
            Console.Write("Enter the numbers in the array:");
            //
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of elements in the array:");
            //
            for (i = 0; i < n; i++) 
            {
                Console.Write("{0}     "+ i);
                a[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.Write("The values stored in the array are:");
            for ( i = 0; i < n; i++)
            {
                Console.Write("{0}" + a[i]);
            }
            Console.Write("the values in the reversed form are");
            for( i=n-1;i>=0; i--)
            {
                Console.Write("{0}" + a[i]);
            }

        }
    }
}
