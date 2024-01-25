namespace ArchitectArithmeticGreatMosqueOfMecca
{
    class Program
    {
        // In this section we will write a program tha gives the total cost of the flooring material for the Great Mosque of Mecca, in Mecca, Saudi Arabia
        static void Main(string[] args)
        {
            // Here I need to get the length and width of the first rectangle and return the area!
            double length1 = 284;
            double width1 = 264;

            // Here I get the first rectangle area back from the method!
            double firstRectangleArea = FirstRectangle(length1, width1);

            // Here I need to get the length and width of the second rectangle and return the area!
            double length2 = 106;
            double width2 = 180;

            // Here I get the second rectangle area back from the method!
            double secondRectangleArea = SecondRectangle(length2, width2);

            // Here I need to get the bottom and height of the first triangle and return the area!
            double bottom = 264;
            double height = 84;

            // Here I get the triangle are back from the method!
            double triangleArea = Triangle(bottom, height);
            
            // Now we need to get the total shape area!
            double totalShapeArea = firstRectangleArea + secondRectangleArea + triangleArea;

            // Here we get the floor material pricing
            double floorMaterialPricing = 180;

            // Now we multiply the total shape area with the floor pricing in order to get the total cost!
            double totalCost = totalShapeArea * floorMaterialPricing;

            // And now we need to print the result!
            Console.WriteLine($"The total cost for the flooring material, for the Great Mosque of Mecca is: {Math.Round(totalCost):F2} riyal!");
            // The next step is to round the result to the nearest integer!
        }

        static double FirstRectangle(double length1, double width1)
        {
            double area1 = length1 * width1;
            return area1;
        }

        static double SecondRectangle(double length2, double width2)
        {
            double area2 = length2 * width2;
            return area2;
        }

        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}