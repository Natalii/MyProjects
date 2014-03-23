/*Write an expression that checks if given positive 
 * integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). */

using System;

class Program
{
static void Main()
{
    Console.WriteLine("Enter a positive number:");
    int n = int.Parse(Console.ReadLine());

    bool Prime = true;

    if (n==3)
{
		Prime = false;
}
    if (n==4)
{
    Prime = true;
}
    for (int i = 4; i < n; i++)
		{
		if (n%i== 0)
{
		Prime = false;
}
		}
    Console.WriteLine(Prime);
}
}

