

        //Calculate a circle’s diameter, circumference and area.

        //What will the application do?
        //The application prompts the user to enter a radius; the user may enter a number with decimals(double).
        //The application displays an error if the user enters invalid data and asks the user again for a radius.
        //When the user enters valid data, the application creates an
        //instance of a Circle and then uses its methods to display the Diameter, Circumference and Area.



        //Create a class named Circle to store the data about this circle.
        //This class should contain these constructors and methods:
        //Properties
        //private double radius
        //Constructor
        //public Circle(double radius)

        //Methods
        //public double CalculateDiameter()
        //public double CalculateCircumference()
        //public double CalculateArea()
        //public void Grow()
        //public double GetRadius()

       
using System;

class Circle
{
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Grow()
        {
            radius *= 2;
        }

        public double GetRadius()
        {
            return radius;
        }
    

    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Circle circle;

            do
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius) && radius > 0)
                {
                    circle = new Circle(radius);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            } while (true);

            do
            {
                Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
                Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateArea()}");

                Console.Write("Do you want the circle to grow? (y/n): \n\t");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    circle.Grow();
                }
                else if (response == "n")
                {
                    Console.WriteLine($"Goodbye! The final radius of the circle is: {circle.GetRadius()} \n\t");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter 'y' or 'n'.");
                }
            } while (true);
        }
    }

}
