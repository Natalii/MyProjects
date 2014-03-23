/*Write an expression that checks if given integer is odd or even*/

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number you entered is even.");
        }
        else
        {
            Console.WriteLine("The number you entered is odd.");
        }
    }
}

