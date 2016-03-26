using System;

//Problem 14.	** Dream Item
class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int hoursPerDay = int.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);
        decimal moneyTotal;
        decimal workDays = 0;

        switch (month)
        {
            case "Jan":
                workDays = 21;
                break;
            case "Feb":
                workDays = 18;
                break;
            case "Mar":
                workDays = 21;
                break;
            case "Apr":
                workDays = 20;
                break;
            case "May":
                workDays = 21;
                break;
            case "June":
                workDays = 20;
                break;
            case "July":
                workDays = 21;
                break;
            case "Aug":
                workDays = 21;
                break;
            case "Sept":
                workDays = 20;
                break;
            case "Oct":
                workDays = 21;
                break;
            case "Nov":
                workDays = 20;
                break;
            case "Dec":
                workDays = 21;
                break;
            default:
                Console.WriteLine("Your input is invalid!");
                break;
        }

        moneyTotal = workDays * moneyPerHour * hoursPerDay;

        if (moneyTotal > 700)
        {
            moneyTotal=moneyTotal * 0.1M + moneyTotal;
        }

        if ((moneyTotal - itemPrice) <= 0)
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(moneyTotal - itemPrice));
        }
        else
        {
            Console.WriteLine("Money left = {0:F2} leva.", moneyTotal - itemPrice);  
        }

    }
}
