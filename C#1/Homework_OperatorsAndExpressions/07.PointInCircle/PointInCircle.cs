//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter point coordinate X=");
        double coordX = double.Parse(Console.ReadLine());
        Console.Write("Enter point coordinate Y=");
        double coordY = double.Parse(Console.ReadLine());
        double radius=2;
        bool isInside=((coordX*coordX+coordY*coordY)<=radius*radius);
        Console.WriteLine("Is point (X={0},Y={1}) inside a circle K((0, 0), 2)? {2}",
                            coordX,coordY,isInside);
                
    }
}

