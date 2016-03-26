/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
 * 
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of 
 the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class InCircleOutsideOfRectangle
{
    static void Main()
    {
        double X = Convert.ToDouble(Console.ReadLine());
        double Y = Convert.ToDouble(Console.ReadLine());
        double r = 1.5;
        bool withinCircle = ((X - 1) * (X - 1) + (Y - 1) * (Y - 1)) <= Math.Pow(r, 2);
        bool outsideRect = ((X < -1) || (X > 5) || (Y > 1) || (Y < -1));
        bool checkCond = withinCircle && outsideRect;
        if (checkCond == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no"); 
        }
    }  
}
