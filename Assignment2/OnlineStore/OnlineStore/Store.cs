using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Store
    {
        List<Product> prod = new List<Product>();
        private double total_price = 0;

        public void Add()
        {
            Console.WriteLine("Enter the name of the product: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the price of the product: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the product: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ctegory of the product: ");
            string category = Convert.ToString(Console.ReadLine());

            Product newItem = new Product(name, price, quantity,category);
            prod.Add(newItem);
            this.total_price = price * quantity;
        }
        public void DisplayItems()
        {
            foreach(var Prod  in prod)
            {
                Prod.Display_Details();
            }
        }
    }
}
