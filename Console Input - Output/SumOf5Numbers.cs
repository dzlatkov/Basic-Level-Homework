using System;
/*Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. */

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers separeted by space: ");
        string[] userINput = Console.ReadLine().Split();
        double a = double.Parse(userINput[0]);
        double b = double.Parse(userINput[1]);
        double c = double.Parse(userINput[2]);
        double d = double.Parse(userINput[3]);
        double e = double.Parse(userINput[4]);
        double Sum = a + b + c + d + e;
        Console.WriteLine(Sum);
    }
}
