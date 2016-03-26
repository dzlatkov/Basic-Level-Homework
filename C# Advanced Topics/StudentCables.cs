﻿/*Problem 19.	** – Student Cables*/

using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cableLength = new int[n];
        string[] cableMeasure = new string[n];
        int loseCables = 0;
        int joinCables = 0;
        int studentCables = 0;
        int remainderCables = 0;
        int k = n;
        for (int i = 0; i < n; i++)
        {
            cableLength[i] = int.Parse(Console.ReadLine());
            cableMeasure[i] = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            if (cableLength[i] < 20 && cableMeasure[i] == "centimeters")
            {
                cableLength[i] = 0;
                k--;
            }
            else
            {
                continue;
            }
        }
        loseCables = (k - 1) * 3;
        for (int i = 0; i < n; i++)
        {
            if (cableMeasure[i] == "centimeters" && cableLength[i] != 0)
            {
                joinCables += cableLength[i];
            }
            else if (cableMeasure[i] == "meters")
            {
                joinCables += cableLength[i] * 100;
            }
            else
            {
                continue;
            }
        }
        joinCables = joinCables - loseCables;
        if (joinCables / 504 != 0)
        {
            studentCables = joinCables / 504;
        }
        remainderCables = Math.Abs(joinCables - studentCables * 504);
        Console.WriteLine(studentCables);
        Console.WriteLine(remainderCables);
    }
}
