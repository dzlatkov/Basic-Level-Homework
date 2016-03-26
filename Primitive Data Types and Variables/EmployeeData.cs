using System;
/*
 * A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console.*/
class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Ivanov";
        byte age = 25;
        char gender = 'm';
        int idNumber = 27560001;
        int employeeNum = 27566600;
        Console.WriteLine("Full name: \t\t" + firstName + " " + secondName + "\nAge: \t\t\t" + age + "\nGender \t\t\t" + gender +
            "\nID number: \t\t" + idNumber + "\nUnique employee number: " + employeeNum);
    }
}
