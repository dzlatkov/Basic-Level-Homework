﻿/*Problem 18.** – Inside the Building*/

using System;

class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());
        if ((x1 <= 3 * h && x1 >= 0) && (y1 <= h && y1 >= 0) || (x1 <= 2 * h && x1 >= h) && (y1 <= 4 * h && y1 >= 0))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
        if ((x2 <= 3 * h && x2 >= 0) && (y2 <= h && y2 >= 0) || (x2 <= 2 * h && x2 >= h) && (y2 <= 4 * h && y2 >= 0))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
        if ((x3 <= 3 * h && x3 >= 0) && (y3 <= h && y3 >= 0) || (x3 <= 2 * h && x3 >= h) && (y3 <= 4 * h && y3 >= 0))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
        if ((x4 <= 3 * h && x4 >= 0) && (y4 <= h && y4 >= 0) || (x4 <= 2 * h && x4 >= h) && (y4 <= 4 * h && y4 >= 0))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
        if ((x5 <= 3 * h && x5 >= 0) && (y5 <= h && y5 >= 0) || (x5 <= 2 * h && x5 >= h) && (y5 <= 4 * h && y5 >= 0))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
