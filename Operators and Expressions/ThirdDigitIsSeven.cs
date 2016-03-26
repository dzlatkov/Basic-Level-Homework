/*Problem 5.	Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is 7*/

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine((Int32.Parse(Console.ReadLine()) / 100 % 10 == 7).ToString().ToLower());
    }
}
