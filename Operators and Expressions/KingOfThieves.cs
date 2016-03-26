/*Problem 19.	** King of Thieves
 * 
 *    Once upon a time there was a kingdom and everyone in the kingdom was a thief. 
 * Izzy wanted to become the King of Thieves and so started stealing only perfect gems from other thieves.
 * Help Izzy by showing him what a perfect gem with given parameters should look like.
*/

using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('-'), n / 2 - i),
                new string((symbol), 1 + 2 * i));
        }

        Console.WriteLine("{0}", new string((symbol), n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('-'), 1 + i),
                new string((symbol), n - ((1 + i) * 2)));
        }
    }
}