/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
 * Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume 
 * two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:*/

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal roundedFirst = decimal.Round(firstNum, 6);
            decimal roundedSecond = decimal.Round(secondNum, 6);

            if (roundedFirst > roundedSecond)
            {
                Console.WriteLine("The first number is bigger");
            }
            else if (roundedSecond > roundedFirst)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }
    }

