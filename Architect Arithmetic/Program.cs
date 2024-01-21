﻿namespace Architect_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here I need to get the length and width of the rectangle and return the area!
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            // Here I get the rectangle area!
            double rectangleArea = Rectangle(length, width);

            // Here I need to get the radius of the circle and return the area!
            double radius = double.Parse(Console.ReadLine());

            // Here I get the circle area!
            double circleArea = Circle(radius);

            // Here I need to get the bottom and height of the triangle and return the area!
            double bottom = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Here I get the triangle area!
            double triangleArea = Triangle(bottom, height);

            
            // After we separate the floor plan on a paper, we need to get the result from every shape's area, and then add them together!
            //The total result should be saved in a double varibale, because in this project, we are instructed to work only with the variable double!
            double totalShapeArea = rectangleArea + triangleArea + (circleArea / 2);
            
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
        static double Triangle(double bottom, double height)
        {
            // Here we calculate the area of the triangle!
            double area = 0.5 * bottom * height;
            // Here we return the calculated area,of the triangle, back to the main method!
            return area;
        }
    }
}
