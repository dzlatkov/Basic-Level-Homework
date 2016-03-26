/*Problem 14.	Modify a Bit at Given Position
 * 
We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation
 * of n while preserving all other bits in n. */

using System;

class ModifyBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bitPostion = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            int result = ((1 << bitPostion) | n);
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else if (v == 0)
        {
            int result = (~(1 << bitPostion) & n);
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("Enter 0 or 1");
        }
    }
}
