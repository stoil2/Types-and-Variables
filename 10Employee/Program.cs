using System;

public class Employee
{
    public static void Main()
    {
        string first = "Stefan";
        string last = "Petrov";
        byte age = 32;
        char gender = 'm';
        ulong ID = 8306112507;
        uint employee = 27560000;
        string output = "First name:\t\t{0} \nLast name:\t\t{1} \nAge:\t\t\t{2} \nGender:\t\t\t{3} \nPersonal ID number:\t{4} \nUnique employee number:\t{5}";
        Console.WriteLine(
            output,
            first,
            last,
            age,
            gender,
            ID,
            employee);
    }
}