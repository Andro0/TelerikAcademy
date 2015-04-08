namespace Shape
{
        public class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
        }

        // Square inherits Rectangle so CalculateSurface() is already implemented.
    }

}
