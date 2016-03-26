using System;

/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 *bank name, IBAN, 3 credit card numbers associated with the account. 
 *Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/
class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Petrov";
        string thirdName = "Ivanov";
        object holderName = firstName + " " + secondName + " " + thirdName;
        decimal accountBalance = 255.55m;
        string bankName = "Some bank";
        string iban = "BG80BNBG96611020345678";
        string bic = "STSABGSF";
        ulong creditCardNumber1 = 123456780001111;
        ulong creditCardNumber2 = 123456780001112;
        ulong creditCardNumber3 = 123456780001113;
        Console.WriteLine("Account holder: " + holderName + "\nBalance: \t" + accountBalance + "\nBank: \t\t" + bankName +
            "\nIban: \t\t" + iban + "\nBic: \t\t" + bic + "\nCreditCard1: \t" + creditCardNumber1 +
            "\nCreditCard2: \t" + creditCardNumber2 + "\nCreditCard3: \t" + creditCardNumber3);
    }
}