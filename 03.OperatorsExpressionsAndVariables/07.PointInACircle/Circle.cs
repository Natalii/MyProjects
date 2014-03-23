/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).*/

using System;

class Circle
{
    static void Main()
    {
        Console.WriteLine("Enter the value of point X:");
        double x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of point Y:");
        double y = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the radius of the circle:");
        double radius = float.Parse(Console.ReadLine());
        Console.WriteLine(new string('-',30));

        bool TheCircle = false;
        double PointCenter = Math.Sqrt(x * x + y * y);

        if (PointCenter>= radius)
        {
            TheCircle = true;
        }
        else
        {
            TheCircle = false;
        }
        Console.WriteLine("The point is in teh circle: {0}",TheCircle);
    }
}

