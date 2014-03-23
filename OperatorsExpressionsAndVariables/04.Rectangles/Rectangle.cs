/*Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

using System;

class Rectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the rectangle:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the hight of the rectangle:");
        float hight = float.Parse(Console.ReadLine());

        float perimeter = 2*(width + hight);
        float area =(width * hight);

        Console.WriteLine("The perimeter of the rectangle is:{0:F2}\n The are is : {1:F3}",perimeter,area);
    }
}

