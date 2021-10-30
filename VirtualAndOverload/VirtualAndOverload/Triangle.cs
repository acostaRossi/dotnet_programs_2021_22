namespace VirtualAndOverload
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width) : base(height, width) { }
        public override double CalcArea()
        {
            return Width * Height / 2;
        }
        public override string ToString()
        {
            return $"Triangle with width = { Width } and height = { Height }";
        }
    }
}
