/*Problem 10.	Odd and Even Product
 * 
   You are given n integers (given in a single line, separated by a space). 
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integers with space between them: ");
        string[] num = Console.ReadLine().Split();
        int sumOdd = 1;
        int sumEven = 1;

        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= Convert.ToInt32(num[i]);
            }
            else
            {
                sumEven *= Convert.ToInt32(num[i]);
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product= {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product={0}", sumOdd);
            Console.WriteLine("even_product={0}", sumEven);
        }
    }
}
