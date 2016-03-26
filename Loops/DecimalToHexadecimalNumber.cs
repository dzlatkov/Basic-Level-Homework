/* *Problem 16.	Decimal to Hexadecimal Number
 * 
   Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. */

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter integer number n (0 <= n): ");
        long n;
        bool nParse = long.TryParse(Console.ReadLine(), out n);
        string hex = "";

        if (!nParse || n < 0)
        {
            Console.WriteLine("invalid input");
            return;
        }

        do
        {
            switch (n % 16)
            {
                case 10: hex = "A" + hex; break;
                case 11: hex = "B" + hex; break;
                case 12: hex = "C" + hex; break;
                case 13: hex = "D" + hex; break;
                case 14: hex = "E" + hex; break;
                case 15: hex = "F" + hex; break;
                default: hex = n % 16 + hex; break;
            }
            n = n / 16;
        } while (n > 0);
        Console.WriteLine(hex);
    }
}
