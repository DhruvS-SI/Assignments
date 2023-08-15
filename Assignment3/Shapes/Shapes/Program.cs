namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Circle circle = new Circle();
            Rectangle rect = new Rectangle();
            Triangle triangle = new Triangle();
            do
            {
                Console.WriteLine("Enter 1 to Enter Circle");
                Console.WriteLine("Enter 2 to Enter Rectangle");
                Console.WriteLine("Enter 3 to Enter Triangle");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        circle.calculateArea();
                        circle.calculatePerimeter();
                        break;
                    case 2:
                        rect.calculateArea();
                        rect.calculatePerimeter();
                        break;
                        case 3:
                        triangle.calculateArea();
                        triangle.calculatePerimeter();
                        break;
                }

            } while (choice != 4);

           





            
        }
    }
}