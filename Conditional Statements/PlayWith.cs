/*Problem 9.	Play with Int, Double and String
 * 
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end.
 * Print the result at the console. Use switch statement. */

using System;

class PlayWith
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                Console.WriteLine("Please enter an integer:");
                int userChoiseOne = int.Parse(Console.ReadLine());
                Console.WriteLine(userChoiseOne+1);
                break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                double userChoiseTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(userChoiseTwo+1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string userChoiseThree = Console.ReadLine();
                Console.WriteLine(userChoiseThree+"*");
                break;
            default:
                Console.WriteLine("Incorect input!");
                break;
        }
    }
}