/*Problem 17.	* Calculate GCD
 * 
   Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 * Use the Euclidean algorithm (find it in Internet). */

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter two integer a and b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int quotient = 0;
        int remainder = 1;
        while (remainder != 0)
        {
            remainder = a % b;
            quotient = a / b;
            a = b;
            b = remainder;
        }
        Console.WriteLine(a);
    }
}

