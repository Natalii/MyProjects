using System;

class Concatenation
{
    static void Main(string[] args)
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        object stringConcatenation = firstVariable + " " + secondVariable;
        Console.WriteLine(stringConcatenation);

        string thirdVariable = string(stringConcatenation);
        Console.WriteLine(thirdVariable);
    }
}

