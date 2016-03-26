/*Problem 6.	Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. */

using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        int nFactorial = 1;
        int kFactorial = 1;

        if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            if (i <= k)
            {
                kFactorial *= i;
            }
        }
        Console.WriteLine(nFactorial / kFactorial);
    }
}