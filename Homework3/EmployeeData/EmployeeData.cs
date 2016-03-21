using System;



class EmployeeData
{
    static void Main()
    {
        string firstName="Amanda";
        string lastName = "Jonson";
        string fullName = firstName + " " + lastName;
        sbyte age = 27;
        char gender = 'f';
        ulong personalId = 8306112507;
        uint unEmpNumber = 27563571;
        Console.WriteLine(fullName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(personalId);
        Console.WriteLine(unEmpNumber);
    }
}