using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Smith";
        byte age = 30;
        char gender = 'm';
        long personalID = 8306112507;
        int employeeNumber = 27569999;

        Console.WriteLine("Employee Data:");
        Console.WriteLine("Name: {0} {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}", firstName, lastName, age, gender, personalID, employeeNumber);
    }
}