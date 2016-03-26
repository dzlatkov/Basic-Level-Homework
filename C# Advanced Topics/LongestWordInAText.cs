/*Problem 14.	Longest Word in a Text
 * 
Write a program to find the longest word in a text. */

using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string[] word = Console.ReadLine().Split(new char[] { ',', ';', ' ', '-', '.' },StringSplitOptions.RemoveEmptyEntries);
        string maxWord = word[0];
        for (int i = 0; i < word.Length; i++)
        {
            if (maxWord.Length > word[i].Length)
            {
                continue;
            }
            else
            {
                maxWord = word[i];
            }
        }
        Console.WriteLine(maxWord);

        //string input = Console.ReadLine(); //another solution
        //string[] words = input.Split(new char[] { ' ', '.', ',', ';', ':', '-', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        //string longest = words.OrderByDescending(s => s.Length).First();
        //Console.WriteLine(longest);
    }
}
