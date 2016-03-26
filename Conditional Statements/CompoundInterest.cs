/*Problem 13.	** Compound interest*/

using System;

class CompoundInterest
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        double bankLoan = p * (Math.Pow((1 + i), n));
        double friendLoan =p *(1 + f);

        if (friendLoan <= bankLoan)
        {
            Console.WriteLine("{0:F2} Friend", friendLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Bank", bankLoan);
        }
    }
}
