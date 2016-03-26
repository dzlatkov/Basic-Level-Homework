﻿/*Problem 3.	Check for a Play Card
 * 
    Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. */

using System;

class CheckForPlayCard
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string choise = Console.ReadLine();

        int pos = Array.IndexOf(cards, choise);
        if (pos > -1)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
