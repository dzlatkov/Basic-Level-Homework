using System;
//Problem 8. Square Root
//Create a console application that calculates and prints the square root of the number 12345.
//Find in Internet “how to calculate square root in C#”.
class SquareRoot
{
    static void Main()
    {
        Console.WriteLine(Math.Sqrt(12345));
        /*Second solution
        Console.Write("Enter number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(number));*/
    }
}