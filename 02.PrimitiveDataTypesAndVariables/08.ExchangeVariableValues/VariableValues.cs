using System;

    class VariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a={0} and b = {1}",a,b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0} and b = {1}",a,b);
        }
    }

