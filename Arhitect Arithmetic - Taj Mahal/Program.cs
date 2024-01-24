using System.ComponentModel.DataAnnotations;

namespace Arhitect_Arithmetic_Taj_Mahal
{
    class Program
    {   
        //In this section we will write a program that gives the total cost of the flooring material for the "Taj Mahal", in Agra, India.
        static void Main(string[] args)
        {
            // Here I need to get the length and width of the rectangle and return the area!
            double length = 90.5;
            double width = 90.5;

            // Here I get the rectangle area back from the method!
            double rectangleArea = Rectangle(length, width);

            // Here I need to get the bottom and height of the triangle and return the area!
            double bottom = 24.0;
            double height = 24.0;

            // here I get the triangle area back from the method!
            double triangleArea = Triangle(bottom, height);

            // After we separate the floor plan on a paper, we need to get the result from every shape's area, and add them back together!
            // The total result should be saved in a double variable, because in this project, we are instructed to work only with the variable double!
            double totalShapeArea = rectangleArea + triangleArea;

            // Now in order to do the next step, we need to write the flooring price!
            double flooringMaterialPrice = 180;

            // And now if we want to get the total cost of the flooring material, we need to multiply the totalShapeArea by the flooring material price!
            double totalCost = totalShapeArea * flooringMaterialPrice;

            // And now we need to print the result!
            Console.WriteLine($"The total cost of the flooring material for the Taj Mahal is {totalCost} rupee!");
        }

        static double Rectangle(double length, double width)
        {
            // Here we calculate the area of the rectangle!
            
            double area = length * width;

            // Here we return the calculated area of the rectangle, back to the main method!
            return area;
        }

        static double Triangle(double bottom, double height)
        {
            // Here we calculate the area of the triangle!
            double area = bottom * height;

            // In order to get the right amount of triangles we need to multiply the area by 4, because the triangles are 4 in total!
            area *= 4;

            // Here we return the calculated area of the triangle, back to the main method!
            return area;
        }
    }
}