using System;
/*Problem 4.	Number Comparer
Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements*/

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        double result = Math.Max(a, b);
        Console.WriteLine("The bigger number is: " + result);
    }
}