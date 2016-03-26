using System;
/* 6. Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter constantas a, b and c for the quadratic equation ax2 + bx + c = 0: ");
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * (a * c);
        if (discriminant > 0 && a != 0)
        {
            Console.WriteLine("There are two real roots.");
            double firstRealRoot = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.Write("X1= {0}", firstRealRoot);
            double secondRealRoot = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.Write("\nX2= {0}\n\n", secondRealRoot);
        }
        else if (discriminant == 0 && a != 0)
        {
            Console.WriteLine("There is one real root.");
            double onlyOneRoot = (-b) / (2 * a);
            Console.WriteLine("X1=X2= {0}", onlyOneRoot);
        }
        else
        {
            Console.WriteLine("No real roots.");
        }
    }
}
