/*Problem 10.	* Beer Time
 * 
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
 * a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or
 * “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 
*/

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        System.Globalization.CultureInfo ENG = new System.Globalization.CultureInfo("en-US");
        Console.Write("Input time [hh:mm tt] AM/PM: ");
        string timeString = Console.ReadLine();

        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        DateTime time;

        bool parseTime = DateTime.TryParseExact(timeString, "h:mm tt", ENG, System.Globalization.DateTimeStyles.None, out time);
        bool beerTime = time >= startTime || time < endTime;

        if (parseTime)
        {
            if (beerTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
