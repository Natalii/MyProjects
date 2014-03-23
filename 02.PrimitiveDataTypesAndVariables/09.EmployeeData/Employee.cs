/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
	First name,	Last name ,Age (0...100) ,Gender (m or f), Personal ID number (e.g. 8306112507), Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.*/

using System;

class Employee
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string LastName = Console.ReadLine();
        Console.WriteLine("Ënter your age:");
        int Age = int.Parse(Console.ReadLine());
        while (Age <= 0 || Age > 100)
        {
            Console.WriteLine("Enter correct age:");
            Age = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter your gender: f-female, m-male:");
        string gender = Console.ReadLine();
        Console.WriteLine("Enter your personal Id number:");
        int PersonalID = int.Parse(Console.ReadLine());
        int EmployeeNumber = 2376849503;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Personal information");
        Console.WriteLine();
        Console.WriteLine("FirstName: {0}\nLastName:{1}\nAge:{2}",FirstName,LastName,Age);
        if (gender == "f") 
        {
            Console.WriteLine(" Gender:Female");
        }
        else if (gender=="m")
        {
            Console.WriteLine("Gender:Male");
        }
        else
        {
            Console.WriteLine("Gender:Error");
        }
        Console.WriteLine("Personal ID: {0}\nEmployee Number: {1}\nGender: {2}",PersonalID,EmployeeNumber);
    }

}

