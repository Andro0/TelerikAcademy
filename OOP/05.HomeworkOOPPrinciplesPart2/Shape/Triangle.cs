
namespace Shape
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {

        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2.0;
        }
    }
}
