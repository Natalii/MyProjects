using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your num:");
        int n = int.Parse(Console.ReadLine());

        bool isThirdDigit7 = false;
        n = n / 100;
        if (n%10==7)
        {
            isThirdDigit7 = true;  
        }

        else
        {
            isThirdDigit7 = false;
        }
        Console.WriteLine(isThirdDigit7);
    }
}

