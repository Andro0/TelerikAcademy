using System;
using EuclidianSpace.Models;

namespace EuclidianSpace.Extensions
{
    /*Problem 3. Static class
        Write a static class with a static method to calculate the distance between two points in the 3D space.*/
    public static class Point3DDistance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secodPoint)
        {
            double distance = 0.0;
            distance = Math.Sqrt(
                (firstPoint.X - secodPoint.X) * (firstPoint.X - secodPoint.X) +
                (firstPoint.Y - secodPoint.Y) * (firstPoint.Y - secodPoint.Y) +
                (firstPoint.Z - secodPoint.Z) * (firstPoint.Z - secodPoint.Z));

            return distance;
        }
    }
}
