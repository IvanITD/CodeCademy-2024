namespace Architect_Arithmetic_Pantheon
{
    internal class Program
    {

        //In this section we will write a program that gives the total cost of the flooring material for the "Pantheon", in Rome, Italy.
        static void Main(string[] args)
        {
            // Here I need to get the length and width of the rectangle and return the area!
            double length = 15;
            double width = 18;

            // Here I get the rectangle area back from the method!
            double rectangleArea = Rectangle(length, width);

            // Here I need to get the radius of the circle and return the area!
            double radius = 21.5;

            // Here I get the circle area!
            double circleArea = Circle(radius);


            // After we separate the floor plan on a paper, we need to get the result from every shape's area, and then add them together!
            //The total result should be saved in a double variable, because in this project, we are instructed to work only with the variable double!
            double totalShapeArea = rectangleArea + (circleArea / 2);

            // Now in order to do the next step, we need to write the flooring price!
            double flooringMaterialPrice = 180;

            // And now in order to get the cost of the flooring material, we need to multiply the total shape area by the price of the material!
            double totalCost = totalShapeArea * flooringMaterialPrice;

            // And now we need to print the result!
            Console.WriteLine($"The total cost for the flooring material, for the Pantheon, is: {Math.Round(totalCost):F2} euro!"); 
            // The next step is to round the result to the nearest integer!
            
        }
        static double Rectangle(double length, double width)
        {
            // Here we calculate the area of the rectangle!
            double area = length * width;
            // Here we return the calculated area, of the rectangle, back to the main method!
            return area;
        }
        static double Circle(double radius)
        {
            // Here we calculate the area of the circle!
            double area = Math.PI * Math.Pow(radius, 2);
            // Here we return the calculated area, of the circle, back to the main method!
            return area;
        }
        
        
    }
}
