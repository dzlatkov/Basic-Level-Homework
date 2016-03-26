
//Problem 1.	Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double num3 = double.Parse(Console.ReadLine());
        double result = num1 + num2 + num3;
        Console.WriteLine("The sum of " + num1 + ", " + num2 + " and " + num3 + " is: " + result);
    }
}
