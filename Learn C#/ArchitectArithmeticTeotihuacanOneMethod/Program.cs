namespace ArchitectArithmeticTeotihuacanOneMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost(
            double length = 2500,
            double width = 1500,
            double radius = 187.5,
            double bottom = 750,
            double height = 500
        )
        {
            double rectangleArea = length * width;
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double triangleArea = 0.5 * bottom * height;

            double totalShapeArea = rectangleArea + circleArea + triangleArea;

            double flooringPrice = 180;

            double totalCost = totalShapeArea * flooringPrice;

            Console.WriteLine($"The total cost for the flooring material, for the Teotihuacan is: {Math.Round(totalCost):F2} pesos!");
        }

    }
}