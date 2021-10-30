namespace VirtualAndOverload
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width) { }
        public override double CalcArea()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Rectangle with width = { Width } and height = { Height }";
        }
    }
}
