using System;

// Problem 13.	** Currency Check
class CurrencyCheck
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double mNormalPrice = double.Parse(Console.ReadLine());

        double rubles = (r / 100 * 3.5);
        double dollars = d * 1.5;
        double euro = e * 1.95;
        double levaSpecial = b / 2;

        double min; // Get the lowest price;

        if (rubles < dollars && rubles < euro && rubles < levaSpecial && rubles < mNormalPrice)
        {
            min = rubles;
            Console.WriteLine("{0:F2}", min);
        }
        else if (dollars < euro && dollars < levaSpecial && dollars < mNormalPrice && dollars < rubles)
        {
            min = dollars;
            Console.WriteLine("{0:F2}", min);
        }
        else if (euro < levaSpecial && euro < levaSpecial && euro < mNormalPrice && euro < rubles && euro < dollars)
        {
            min = euro;
            Console.WriteLine("{0:F2}", min);
        }
        else if (levaSpecial < mNormalPrice && levaSpecial < rubles && levaSpecial < dollars && levaSpecial < euro)
        {
            min = levaSpecial;
            Console.WriteLine("{0:F2}", min);
        }
        else if (mNormalPrice < rubles && mNormalPrice < dollars && mNormalPrice < euro && mNormalPrice < levaSpecial)
        {
            min = mNormalPrice;
            Console.WriteLine("{0:F2}", min);
        }

        /* Here is second solution how to find the lowest number among others:
         
        double lowestPrice = double.MaxValue;
        lowestPrice = Math.Min(rubles, lowestPrice);
        lowestPrice = Math.Min(dollars, lowestPrice);
        lowestPrice = Math.Min(euro, lowestPrice);
        lowestPrice = Math.Min(levaSpecial, lowestPrice);
        lowestPrice = Math.Min(mNormalPrice, lowestPrice);

        Console.WriteLine("{0:F2}", lowestPrice);
         */
    }
}