/*Problem 8.	Catalan Numbers
 * 
In combinatorics, the Catalan numbers are calculated by the following formula:
  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialNplus1 = 1;
        BigInteger factorialN = 1;

        if (n < 0 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;
            if (i <= n)
            {
                factorialN *= i;
            }
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorialNplus1 *= i;
        }
        Console.WriteLine(factorial2N / (factorialNplus1 * (factorialN)));
    }
}
