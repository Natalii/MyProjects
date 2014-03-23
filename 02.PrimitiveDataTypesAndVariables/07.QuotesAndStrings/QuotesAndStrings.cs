using System;

class QuotesAndStrings
{
    static void Main(string[] args)
    {
        string FirstValue = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("Without quoted strings: {0}",FirstValue);
        string SecondValue = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("With quoted string: {0}",SecondValue);
    }
}

