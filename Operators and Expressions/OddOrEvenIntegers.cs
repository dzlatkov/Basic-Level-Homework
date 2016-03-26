/*Problem 1.	Odd or Even Integers
 * 
Write an expression that checks if given integer is odd or even. */

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine((Int32.Parse(Console.ReadLine()) % 2 != 0).ToString().ToLower());
    }   //Note that the answers should be with lower letters.
}

