namespace EuclidianSpace.Models
{
    using System.Collections;
    using System.Collections.Generic;

    /*Problem 4. Path
        Create a class Path to hold a sequence of points in the 3D space.
        Create a static class PathStorage with static methods to save and load paths from a text file.
        Use a file format of your choice.*/
    public class Path : IEnumerable<Point3D>
    {
        private ICollection<Point3D> points;

        public Path()
        {
            this.points = new HashSet<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
