using System;
/*Problem 12.	Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console.
 *Try to add some number or the null literal to these variables and print the result.*/

class NullValuesArithmetic
{
    static void Main()
    {
        int? valueInt = null;
        double? valueDouble = null;
        Console.WriteLine(valueInt);
        Console.WriteLine(valueDouble);
        Console.WriteLine(valueInt + 2);
        Console.WriteLine(valueDouble + 2);
        Console.WriteLine(valueInt + null);
        Console.WriteLine(valueDouble + null);
    }
}
