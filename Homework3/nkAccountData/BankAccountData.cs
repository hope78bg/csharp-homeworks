using System;



class BankAccountData
{
    static void Main()
    {
        string firstName="Ivan";
        string middleName = "Petrov";
        string lastName = "Todorov";
        string fullName = firstName + " " + middleName + " " + lastName;
        decimal amountMoney = 3542.58m;
        string bankName = "RaiffeisenBank";
        string iBAN = "BG55RZBB91551000158680";
        ulong firstCrCardNubmer = 3568610655666282L;
        ulong secondCrCardNumber = 3383830611250700L;
        ulong thirdCrCardNubmer = 7524610655116241L;
        Console.WriteLine(fullName);
        Console.WriteLine(amountMoney);
        Console.WriteLine(bankName);
        Console.WriteLine (iBAN);
        Console.WriteLine(firstCrCardNubmer);
        Console.WriteLine(secondCrCardNumber);
        Console.WriteLine(thirdCrCardNubmer);
    }
}