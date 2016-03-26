/*Problem 12.	Count of Names
 * 
    Write a program that reads a list of names and prints for each name how many times it appears in the list.
 * The names should be listed in alphabetical order. Use the input and output format from the examples below. */

using System;
using System.Collections.Generic;
using System.Linq;
class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter list of names on a line, separated by a space:");
        List<string> input = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        List<string> names = input.Distinct().OrderBy(c => c).ToList();

        foreach (string name in names)
        {
            Console.WriteLine("{0} -> {1}", name, input.Count(x => x == name));
        }
    }
}
