using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ControlStructuresPrice
    {
        public static void Main(string[] args)
        {
            double limit = 10000;
            double price;

            Console.Write("Enter the purchase price: ");
            price = Convert.ToDouble(Console.ReadLine());

            if (price > limit)
                Console.WriteLine("Error!");
            else
                Console.WriteLine("Approved");
        }
    }
}
