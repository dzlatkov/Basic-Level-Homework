using System;
/*Problem 5.	Formatting Numbers
Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 
 *4 virtual columns on the console. Each column should have a width of 10 characters. 
 *The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, 
 *then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after 
 *the decimal point, left aligned. */

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer a (0<=a<=500): ");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Console.WriteLine("Enter float b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter float c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
        Console.Write("|{0,10}|",
        Convert.ToString(a, 2).PadLeft(10, '0'));
        string str = b.ToString();
        int index = str.IndexOf(".");
        if (index == -1)
        {
            Console.Write("{0,10}|", b);
        }
        else
        {
            Console.Write("{0,10:F2}|", b);
        }
        str = c.ToString();
        index = str.IndexOf(".");
        if (index == -1)
        {
            Console.Write("{0,-10}|", c);
        }
        else
        {
            Console.Write("{0,-10:F3}|", c);
        }
        Console.WriteLine();
    }
}
