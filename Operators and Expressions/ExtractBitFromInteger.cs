/*Problem 12.	Extract Bit from Integer
 * 
Write an expression that extracts from given integer n the value of given bit at index p. */

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bitPostion = int.Parse(Console.ReadLine());
        int result = (n >> bitPostion) & 1;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(result);
    }
}
