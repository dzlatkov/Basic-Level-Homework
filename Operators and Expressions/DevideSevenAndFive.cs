/*Problem 3.	Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/

using System;

class DevideSevenAndFive
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 7 == 0 && n % 5 == 0 && n != 0)
        {
            Console.WriteLine(true.ToString().ToLower());
        }
        else
        {
            Console.WriteLine(false.ToString().ToLower());
        }
    }
}

