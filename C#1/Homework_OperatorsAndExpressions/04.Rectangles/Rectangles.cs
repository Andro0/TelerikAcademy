//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width of rectangle:");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height of rectangle:");
        double height = double.Parse(Console.ReadLine());

        double recPerimeter = 2 * width + 2 * height;
        double recArea = width * height;

        Console.WriteLine("Rectangle with width {0} and height {1} has perimeter {2} and area {3}",
                            width, height, recPerimeter, recArea);

    }
}

