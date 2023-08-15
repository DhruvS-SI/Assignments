using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal interface Ishapes
    {
        void calculateArea();

        void calculatePerimeter();

    }
    class Circle : Ishapes 
    {
        int radius;
        private double area;
        private double perimeter;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
       
        public Circle(int Radius)
        { 
            this.radius = Radius; 
           
        }
        public Circle() { }
        public void calculateArea() 
        {
            Console.WriteLine("Enter the radius of the circle : ");
            radius = Convert.ToInt32(Console.ReadLine());
         
            area = 3.14 * radius * radius;
            Console.WriteLine($"The Area of the circle is : {area}");
        }
        public void calculatePerimeter() 
        {
           perimeter =  2 * 3.14 * radius;
           Console.WriteLine($"The perimeter of the Circle is : {perimeter}");
        }
    }
    class Rectangle : Ishapes 
    {
        private int length;
        private int breadth;
        private double area1;
        private double perimeter1;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public Rectangle(int Length,int Breadth)
        {
            this.length = Length;
            this.breadth = Breadth;
           
        }
        public Rectangle() { }
        public void calculateArea() 
        {
            Console.WriteLine("Enter the length of the rectangle : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the rectangle : ");
            breadth = Convert.ToInt32(Console.ReadLine());
            area1 = length * breadth;
            Console.WriteLine($"The Area of the Rectangle is :{area1}");
        }
        public void calculatePerimeter() 
        {
            perimeter1 =  2 * (length + breadth);
            Console.WriteLine($"The perimeter of the rectangle is : {perimeter1}");

        }
    }
    class Triangle : Ishapes
    {
        private int base1;
        private int height;
        private int base2;
        private int base3;
        private double area3;
        private double perimeter3;

        public int Base1
        {
            get { return base1; }
            set { base1 = value; }
        }
        public int Base2
        {
            get { return base2; }
            set { base2 = value; }
        }
        public int Base3
        {
            get { return base3; }
            set { base3 = value; }

        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Triangle(int Base1,int Height,int Base2,int Base3)
        {
            this .base1 = Base1;
            this .height = Height;
            this .base2 = Base2;
            this .base3 = Base3;
        }
        public Triangle() { }
        public void calculateArea()
        {
            Console.WriteLine("Enter the Base 1 : ");
            base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = Convert.ToInt32(Console.ReadLine());
            area3 = 0.5 * base1 * height;
            Console.WriteLine($"The Area of a triangle is : {area3}");
           
        }
        public void calculatePerimeter()
        {
            Console.WriteLine("Enter the base 2 is : ");
            base2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the base 3 is : ");
            base3 = Convert.ToInt32(Console.ReadLine());
            perimeter3 = base1 * base2 * base3;
            Console.WriteLine($"The Perimeter of the triangle is : {perimeter3}");
        }
    }
   
}
