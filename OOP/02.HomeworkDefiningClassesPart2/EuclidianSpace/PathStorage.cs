using EuclidianSpace.Models;
using System.IO;

namespace EuclidianSpace
{
    /*Problem 4. Path
            Create a class Path to hold a sequence of points in the 3D space.
            Create a static class PathStorage with static methods to save and load paths from a text file.
            Use a file format of your choice. */
    public static class PathStorage
    {
        public static void SavePath(Models.Path path, string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    sw.WriteLine(point);
                }
            }
        }

        public static Models.Path LoadPath(string filePath)
        {
            var path = new Models.Path();
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
