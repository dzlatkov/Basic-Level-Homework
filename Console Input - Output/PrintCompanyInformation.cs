
//Problem 2.	Print Company Information
//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter company address: ");
        string companyAddress = Convert.ToString(Console.ReadLine());
        Console.Write("Enter phone number: ");
        string phoneNumber = Convert.ToString(Console.ReadLine());
        Console.Write("Enter fax numer: ");
        string faxNumber = Convert.ToString(Console.ReadLine());
        Console.Write("Web site: ");
        string webSite = Convert.ToString(Console.ReadLine());
        Console.Write("Manager's first name: ");
        string managerFirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Manager's last name: ");
        string managerLastName = Convert.ToString(Console.ReadLine());
        Console.Write("Manager's age: ");
        byte managerAge = Convert.ToByte(Console.ReadLine());
        Console.Write("Manager's phone: ");
        string managerPhone = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Company name: \t\t\t" + companyName);
        Console.WriteLine("Company Address: \t\t" + companyAddress);
        Console.WriteLine("Phone number: \t\t\t" + phoneNumber);
        Console.WriteLine("Fax number: \t\t\t" + faxNumber);
        Console.WriteLine("Web site: \t\t\t" + webSite);
        Console.WriteLine("Manager's first name: \t\t" + managerFirstName);
        Console.WriteLine("Manager's last name: \t\t" + managerLastName);
        Console.WriteLine("Manager's age: \t\t\t" + managerAge);
        Console.WriteLine("Manager's phone number: \t" + managerPhone);
    }
}
