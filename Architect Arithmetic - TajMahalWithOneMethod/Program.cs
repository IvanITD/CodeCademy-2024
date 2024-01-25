namespace Architect_Arithmetic__TajMahalWithOneMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost(
            double length = 90.5,
            double width = 90.5,
            double bottom = 24.0,
            double height = 24.0
        )
        {
            double rectangleArea = length * width;
            double triangleArea = 0.5 * bottom * height; 
            triangleArea *= 4;

            double flooringMaterialCost = 180;
            
            double totalShapeArea = rectangleArea + triangleArea;
            double totalCost = totalShapeArea * flooringMaterialCost;
            Console.WriteLine($"The total cost of the flooring material for the Taj Mahal is {Math.Round(totalCost)} rupee!");

        }
    
    }
}