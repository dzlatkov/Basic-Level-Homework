
//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is: {0}", Math.Round((Math.PI) * 2 * r, 2));
        Console.WriteLine("The area of the circle is: {0}", Math.Round((Math.PI) * (Math.Pow(r, 2)), 2));
    }
}
