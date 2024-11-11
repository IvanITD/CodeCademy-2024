using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace ArchitectArithmeticWholeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What monument would you like to work with? \nYou have the following options:\n");
            Console.WriteLine($"1) Pantheon\n2) Teotihuacan\n3) Taj Mahal\n4) Great Mosque of Mecca");
            Console.WriteLine();
            Console.WriteLine($"Pick the one you like!");
            string flooringPlan = Console.ReadLine();

            if (flooringPlan == "Pantheon")
            {
                double pantheon = Pantheon();
                Console.WriteLine($"The plan for the monument costs: {Math.Round(pantheon):F2} euros!");
            }
            else if (flooringPlan == "Teotihuacan")
            {
                
                double teotihuacan = Teotihuacan();
                Console.WriteLine($"The plan for the monument costs: {Math.Round(teotihuacan):F2} pesos!");
            }
            else if (flooringPlan == "Taj Mahal")
            {
                double tajMahal = TajMahal();
                Console.WriteLine($"The plan for the monument costs: {Math.Round(tajMahal):F2} rupee!");
            }
            else if (flooringPlan == "Great Mosque of Mecca")
            {
                double greatMosqueOfMecca = GreatMosqueOfMecca();
                Console.WriteLine($"The plan for the monument costs: {Math.Round(greatMosqueOfMecca):F2} riyal!");
            }            
        }

        static double Pantheon(
            double length = 15,
            double width = 18,
            double radius = 21.5
        )
        {
            double rectangleArea = length * width;
            double circleArea = Math.PI * Math.Pow(radius,2);
            
            double totalShapeArea = rectangleArea + circleArea;
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;

            return totalCost;
        }

        static double Teotihuacan(
            double length = 2500,
            double width = 1500,
            double bottom = 750,
            double height = 500,
            double radius = 375 / 2
        )
        {
            double rectangleArea = length * width;
            double triangleArea = bottom * height;
            double circleArea = Math.PI * Math.Pow(radius, 2);

            double totalShapeArea = rectangleArea + triangleArea + circleArea;
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;

            return totalCost;
            
        }

        static double TajMahal(
            double length = 90.5,
            double width = 90.5,
            double bottom = 24.0,
            double height = 24.0

        )
        {
            double rectangleArea = length * width;
            double triangleArea = bottom * height;
            triangleArea *= 4;
            double totalShapeArea = rectangleArea - triangleArea;
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;

            return totalCost;
        }

        static double GreatMosqueOfMecca(
            double length1 = 284,
            double width1 = 264,
            double length2 = 180,
            double width2 = 106,
            double bottom = 264,
            double height = 84
        )
        {
            double firstRectangleArea = length1 * width1;
            double secondRectangleArea = length2 * width2;
            double triangleArea = bottom * height;

            double totalShapeArea = firstRectangleArea + secondRectangleArea - triangleArea;
            double flooringMaterialPrice = 180;
            double totalCost = totalShapeArea * flooringMaterialPrice;

            return totalCost;
        }
    }
}