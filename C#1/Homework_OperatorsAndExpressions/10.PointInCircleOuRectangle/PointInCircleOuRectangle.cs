/*  Write an expression that checks for given point (x, y) if it is within the circle 
    K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;
class PointInCircleOuRectangle
{
    static void Main()
    {
        Console.Write("Enter point coordinate X=");
        double coordX = double.Parse(Console.ReadLine());
        Console.Write("Enter point coordinate Y=");
        double coordY = double.Parse(Console.ReadLine());
        double radius = 1.5;
        double Xk = 1;
        double Yk = 1;

        bool isInCircle = ((Xk-coordX)*(Xk-coordX) + (Yk-coordY)*(Yk-coordY)) <= (radius) * (radius);
        bool isOutRectangle = ((coordX < -1) || (coordX > 5) || (coordY < -1) || (coordY > 1));

        Console.WriteLine("Is point (X={0},Y={1}) inside a circle K and outside rectangle R? {2}",
            coordX, coordY, isInCircle && isOutRectangle?"yes":"no");

    }
}
