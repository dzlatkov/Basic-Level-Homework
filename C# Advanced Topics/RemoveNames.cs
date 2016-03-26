/*Problem 9.	Remove Names
 * 
    Write a program that takes as input two lists of names and removes from the first list all names given in the second list.
 * The input and output lists are given as words, separated by a space, each list at a separate line. */

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> namesOne = new List<string>();
        string[] firstNames = Console.ReadLine().Split();
        for (int i = 0; i < firstNames.Length; i++)
        {
            namesOne.Add(firstNames[i]);
        }
        List<string> namesTwo = new List<string>();
        string[] secondNames = Console.ReadLine().Split();
        for (int i = 0; i < secondNames.Length; i++)
        {
            namesTwo.Add(secondNames[i]);
        }
        List<string> namesGeneral = new List<string>();
        foreach (var item in namesOne)
        {
            if (namesTwo.Contains(item))
            {
                continue;
            }
            else
            {
                namesGeneral.Add(item);
            }
        }
        foreach (var item in namesGeneral)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}