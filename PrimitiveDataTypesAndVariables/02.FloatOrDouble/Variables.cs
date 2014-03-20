/*Which of the following values can be assigned to a variable of type float and which to a variable
 * of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

using System; 

namespace _02.FloatOrDouble
{
    class Variables
    {
        static void Main()
        {
            double doubleA = 34.567839023;
            double doubleB = 8923.1234857;
            float floatC = 12.345f;
            float floatD = 3456.091f;
            Console.WriteLine(" Double types are: {0} and {1}", doubleA, doubleB);
            Console.WriteLine("Float types are: {0} and {1}", floatC,floatD);
        }
    }
}
