/*Problem 6.	Four-Digit Number
 * 
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).*/

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four-digit number:");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;               //Gets first number.
        int b = (number / 100) % 10;                //Gets second number.
        int c = (number / 10) % 10;                 //Gets third number.
        int d = number % 10;                        //Gets last number.
        Console.WriteLine("Sum of digits: {0}", a + b + c + d);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in front {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", a, c, b, d);
    }
}

