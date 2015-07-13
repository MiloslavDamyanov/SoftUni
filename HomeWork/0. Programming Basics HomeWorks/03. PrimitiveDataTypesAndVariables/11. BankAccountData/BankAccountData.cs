using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Jameson";
        string lastName = "Smith";
        decimal ballance = 1505841;
        string iban = "BGNR0011234564456";
        string bankName = "United Bulgarian Bank";
        ulong creditCardVisa = 5446322168999457;
        ulong creditCardMaster = 2245685546655445;
        ulong creditCard = 5446322556897557;

        Console.WriteLine("Bank account:\nHolder name: {0} {1} {2}\nAvailable amount of money: {3}\nIBAN: {4}\nBank name: {5}\nCredit Cards: \n {6}\n {7}\n {7}", firstName, middleName, lastName, ballance, iban, bankName, creditCardVisa, creditCardMaster, creditCard);
    }
}