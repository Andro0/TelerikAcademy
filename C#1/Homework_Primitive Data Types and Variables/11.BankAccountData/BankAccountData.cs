/*  A bank account has a holder name (first name, middle name and last name), available amount
    of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using 
    the appropriate data types and descriptive names. */

using System;
class BankAccountData
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string firstName = "William";
        string midName = "Henry";
        string lastName = "Gates";
        decimal balance = 80400000000.01m;
        string bankName = "Корпоративна търговска банка АД";
        string iban = "BG43 STSA 9300 0017 3594 06";
        ulong firstCardNum = 4012888888881881;
        ulong secondCardNum = 4012888888881881;
        ulong thirdCardNum = 4012888888881881;

        Console.WriteLine("Bank Account Information");
        Console.WriteLine("".PadLeft(43, '-'));
        Console.WriteLine("Account holder name: {0} {1} {2}", firstName, midName, lastName);
        Console.WriteLine("Account balance: {0}", balance.ToString("C"));
        Console.Write("Bank name: {0}\nIBAN: {1}\nFirst credit card number:  {2}\nSecond credit card number: {3}\n" +
              "Third credit card number:  {4}\n", bankName, iban, firstCardNum, secondCardNum, thirdCardNum);
        
    }
}

