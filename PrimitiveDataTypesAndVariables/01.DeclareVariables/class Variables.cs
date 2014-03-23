/*Task 1. Declare five variables choosing for each of them 
the most appropriate of the types byte, sbyte, short, 
ushort, int, uint, long, ulong to represent 
the following values: 52130, -115, 4825932, 97, -10000. */
using System;


namespace DeclareVariables
{ }
class Variables
{
    static void Main()
    {
        ushort uShortNum = 52130;
        byte byteNum = 97;
        sbyte  sbyteNum = -115;
        int intNum = 4825932;
        short shortNum = -10000;
        Console.WriteLine("For {0} - ushort, {1} - byte, {2} - sbyte, {3} - int, {4} - short.", uShortNum, byteNum,sbyteNum,intNum,shortNum);

    }
}

