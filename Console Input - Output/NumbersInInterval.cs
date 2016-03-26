using System;

/*Problem 11* Numbers in Interval Dividable by Given Number
 * Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0. */

class NumbersInInterval
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);
    }
}
