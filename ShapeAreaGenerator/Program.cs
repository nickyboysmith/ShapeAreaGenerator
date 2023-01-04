using System;

namespace ShapeAreaGenerator
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {

            //1.Square: Square 10
            //2.Rectangle: Rectangle 20 10
            //3.Triangle: Triangle 15 10
            //4.Circle: Circle 15
            //5.Sphere: Sphere 20


            Console.WriteLine("Welcome to the Shape Area Generator App");
            Console.WriteLine("Results will be logged to ShapeAreaGeneratorLog.txt which can be found in your Documents directory.");
            Console.WriteLine("It is case sensitive and no validation is present on the dimensions.");
            Console.WriteLine("Example Usage:");
            Console.WriteLine("Square 10");
            Console.WriteLine("Rectangle 20 10");
            Console.WriteLine("Triangle 15 10");
            Console.WriteLine("Circle 15");
            Console.WriteLine("Sphere 20");
            Console.WriteLine("Exit will quit the console");

            for (int i = 0; i < 99; i++)
            {

                // Wait for User Input
                string args = Console.ReadLine();
 
                string[] values = args.Split(" ");

                if (values[0] == "Square" && values.Length > 1)
                {
                    Square sq = new Square(float.Parse(values[1]));
                    sq.CalculateArea();
                    sq.DisplayOutput();
                    sq.WriteToLog();
                }
                else if(values[0] == "Rectangle" && values.Length > 2)
                {
                    Rectangle rec = new Rectangle(float.Parse(values[1]), float.Parse(values[2]));
                    rec.CalculateArea();
                    rec.DisplayOutput();
                    rec.WriteToLog();
                }
                else if (values[0] == "Triangle" && values.Length > 2)
                {
                    Triangle tri = new Triangle(float.Parse(values[1]), float.Parse(values[2]));
                    tri.CalculateArea();
                    tri.DisplayOutput();
                    tri.WriteToLog();
                }
                else if (values[0] == "Circle" && values.Length > 1)
                {
                    Circle cir = new Circle(float.Parse(values[1]));
                    cir.CalculateArea();
                    cir.DisplayOutput();
                    cir.WriteToLog();
                }
                else if (values[0] == "Sphere" && values.Length > 1)
                {
                    Sphere sph = new Sphere(float.Parse(values[1]));
                    sph.CalculateArea();
                    sph.DisplayOutput();
                    sph.WriteToLog();
                }
                else if (values[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Parameters, Please enter a shape and dimension(s).");
                }

            }
        }
    }
}
