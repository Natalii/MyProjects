/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:*/

using System;

class Program
{
    static void Main()
    {
        int[] numb = new int[4];
        for (int i = 0; i < numb.Length; i++)
        {
            numb[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 40));
        //sum numbers
        int sum = 0;
        for (int i = 0; i < numb.Length; i++)
        {
            sum = sum + numb[i];
        }


        Console.WriteLine("The sum of the number is: {0}", sum);

        //reverse
        Console.Write("The reversed aray is: ");
        for (int i = numb.Length - 1; i >= 0; i--)
        {
            Console.Write(numb[i] + " ");
        }
        Console.WriteLine();

        for (int j = 0; j < numb.Length; j++)
        {
            Console.WriteLine("{0}{1}{2}{3}", numb[0], numb[2], numb[1], numb[3]); break;
        }
    }
}
