/*Problem 11.	Bitwise: Extract Bit #3
 * 
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. */

using System;

class BitwiseExtractBit
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        byte bitPosition = (byte)((n >> 3) & 1);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(bitPosition);
    }
}
