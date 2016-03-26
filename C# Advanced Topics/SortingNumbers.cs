/*Problem 5.	Sorting Numbers
 * 
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. */

using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //using list
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }
        numbers.Sort();
        Console.WriteLine();
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        //int n = int.Parse(Console.ReadLine()); // using array
        //int[] arr = new int[n];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //Array.Sort(arr);
        //foreach (int num in arr)
        //{
        //    Console.WriteLine(num);
        //}
    }
}
