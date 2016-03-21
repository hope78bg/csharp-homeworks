using System;

class PrintCompanyInformation
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
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write(" Manager first name: ");
        string managerFristName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: "); 
        string age = Console.ReadLine();
        Console.Write("Manager Phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\n\rAdress: {1}\n\rTel:  {2}\n\rFax: {3}\n\r Web site: {4}\n\r Manager: {5} {6}\n\r (age: {7}\n\r tel. {8})", 
            companyName, 
            companyAddress,
            phoneNumber, 
            faxNumber,
            webSite, 
            managerFristName, 
            managerLastName, 
            age, 
            managerPhone);
    }
}

