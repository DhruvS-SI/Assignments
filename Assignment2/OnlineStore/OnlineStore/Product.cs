using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Product
    {
        private string name;
        private int price;
        private int quantity;
        private string category;
        private double totalprice;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; }

        }
        public Product(string name,int price,int quantity,string category) 
        {
        this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }

        public double CalPrice()
        {
            totalprice = price * quantity;
            return totalprice;
        }
        public void Display_Details()
        {
            Console.WriteLine("*********** Online Store Details **********");
            Console.WriteLine($"The name of the product is             : {name}");
            Console.WriteLine($"The price of the product is            :{price}");
            Console.WriteLine($"The Quantity of the product is         :{quantity}");
            Console.WriteLine($"The total price of all the product is  :{CalPrice()}");
        }
    }
}
