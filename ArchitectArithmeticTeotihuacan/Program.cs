namespace ArchitectArithmeticTeotihuacan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I set the two sides of the rectangle
            double length = 2500;
            double width = 1500;

            // Here I set the radius of the circle!
            double radius = 187.5;

            // Here I get the bottom and height of the triangle!
            double bottom = 750;
            double height = 500;

            // Here I get each area separately counted
            double rectangleArea = Rectangle(length, width);
            double circleArea = Circle(radius);
            double triangleArea = Triangle(bottom, height);

            // Here I get the total shape area all together!
            double totalShapeArea = rectangleArea + circleArea + triangleArea;

            // The flooring price!
            double flooringPrice = 180;

            // The total cost for the flooring in the Teotihuacan!
            double totalCost = totalShapeArea * flooringPrice;

            // Now we print the total cost of the Teotihuacan to the console and inform the user!
            Console.WriteLine($"The total cost for the flooring material, for the Teotihuacan is {Math.Round(totalCost):F2} pesos!");
            // Here also added the Math.Round in order to get the result to the nearest integer and also get two zeros after the fullstop dot!
        }

        static double Rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}