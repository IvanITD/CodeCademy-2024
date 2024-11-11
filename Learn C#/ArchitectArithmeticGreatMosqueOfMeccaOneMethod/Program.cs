namespace ArchitectArithmeticGreatMosqueOfMeccaOneMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static void CalculateTotalCost(
            double length1 = 284,
            double width1 = 264,
            double length2 = 180,
            double width2 = 106,
            double bottom = 264,
            double height = 84
            )
            {
                double area1 = length1 * width1;
                double area2 = length2 * width2;
                double area = 0.5 * bottom * height;

                double totalShapeArea = area1 + area2 - area;

                double flooringPrice = 180;

                double totalCost = totalShapeArea * flooringPrice;

                Console.WriteLine($"The total cost for the flooring material, for the Great Mosque of Mecca is: {Math.Round(totalCost):F2} riyal!");
            }
    }
}