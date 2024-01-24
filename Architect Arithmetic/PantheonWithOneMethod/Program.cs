namespace Architect_Arithmetic1b
{
    class Program
    {
        static void Main1(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost(
            double length = 4,
            double width = 5,
            double radius = 4,
            double bottom = 10,
            double height = 9
        )
        {
            double rectangleArea = length * width;
            double circleArea = radius * radius * Math.PI;
            double triangleArea = 0.5 * bottom * height;

            double totalShapeArea = rectangleArea + triangleArea + (circleArea / 2);
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;
            Console.WriteLine($"The total cost for the flooring material is: {Math.Round(totalCost)} pesos!");
        }
    }
}