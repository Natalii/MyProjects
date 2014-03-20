/* first name, middle name, last name, available amount of money,
 * bank name,IBAN, 3 credit card numbers associated with the account.Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your second name:");
        string secondName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string thirdName = Console.ReadLine();
        Console.WriteLine("Ented your bank name:");
        string bankName = Console.ReadLine();
        Console.WriteLine("Eter your IBAN(10numbers and characters)");
        string IBAN = Console.ReadLine();
        while (IBAN.Length < 10 || IBAN.Length > 10) 
        {
            Console.WriteLine("Enter correct IBAN numbe");
            IBAN = Console.ReadLine();
        }
        string firstcard = 3674 8930 2145;
        string secondcard = 4785 3029 3847;
        string thirdcard = 3746 4859 4930;
        decimal money = 4 905 8596 333m;
        Console.WriteLine();
        Console.WriteLine(new string('-',20));
        Console.WriteLine("Personal information :");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
        Console.WriteLine("First name : {0}\nMiddle name : {1}\nLast name : {2}\nBank name : {3}\n IBAN : {4}",firstName,middleName,lastName,bankName,iban);
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Bank Information {0} Bank:",bankName);
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
        Console.WriteLine("First name : {0}\nBank name : {1}\nIBAN : {2}\nFirst credit card number : {3}\nSecond credit card number : {4}\n Third credit card number : {5}\nMoney = {6} million dollars",firstName,bankName,iban,firstCard,secondCard,thirdCard,money);

    }
}
