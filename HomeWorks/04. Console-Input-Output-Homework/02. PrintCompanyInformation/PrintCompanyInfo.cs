using System;
class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == string.Empty)
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phon: ");
        string managerPhoneNum = Console.ReadLine(); ;

        Console.WriteLine("\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, phoneNumber);
    }
}