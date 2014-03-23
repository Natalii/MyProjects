using System;

class Division
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int num = int.Parse(Console.ReadLine());
        bool result = false;
        if ((num%5==0)&&(num%7==0))
        {
            result = true;   
        }
         if (num == 0)
        {
            result = false;
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);

    }
}

