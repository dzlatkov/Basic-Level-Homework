using System;
/*Problem 9.	* Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 *Note that you may need to use a for-loop. */

class SumNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double nums;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            nums = double.Parse(Console.ReadLine());
            sum += nums;
        }
        Console.WriteLine(sum);
    }
}