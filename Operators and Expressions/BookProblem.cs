/*Problem 17.	** Book Problem*/

using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int pagesRead = int.Parse(Console.ReadLine());
        const int monthDays = 30;

        if (campingDays >= monthDays || pagesRead == 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double timeNeeded = (int)Math.Ceiling((double)bookPages / ((monthDays - campingDays) * pagesRead));
            Console.WriteLine("{0} years {1} months", (int)timeNeeded / 12, timeNeeded % 12);
        }
    }
}