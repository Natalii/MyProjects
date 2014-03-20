/*Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console. 
 * Try to add some number or the null literal to these variables and print the result.*/

using System;

class ArithmeticValues
{
    static void Main()
    {
        int? a = null;
        double b = double.NaN;
        Console.WriteLine("First output: {0}\n2.Second output: {1}", a, b);
        Console.WriteLine(a + b); //no output
        Console.WriteLine(a + 10); // no output
        Console.WriteLine(b + 10); // NaN 
    }
}

