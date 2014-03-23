using System;

class YourWeightOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        float weight = float.Parse(Console.ReadLine());
        float WeightOnTheMoon = 0.17f * weight;
        Console.WriteLine("Your weight on the Moon will be " + WeightOnTheMoon);

    }
}

