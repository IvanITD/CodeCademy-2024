namespace Architect_Arithmetic_PantheonWithOneMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost(
            double length = 15,
            double width = 18,
            double radius = 21.5
        )
        {
            double rectangleArea = length * width;
            double circleArea = radius * radius * Math.PI;
            
            double totalShapeArea = rectangleArea + (circleArea / 2);
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;
            Console.WriteLine($"The total cost for the flooring material, for the Pantheon is: {Math.Round(totalCost):F2} euro!");
        }
    }
}