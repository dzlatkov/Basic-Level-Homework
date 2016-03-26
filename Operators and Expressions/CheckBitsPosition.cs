/*Problem 13.	Check a Bit at Given Position
 * 
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n 
 has value of 1*/

using System;

class CheckBitsPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bitPostion = int.Parse(Console.ReadLine());
        int result = (n >> bitPostion) & 1;
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine((result == 1).ToString().ToLower());
    }
}
