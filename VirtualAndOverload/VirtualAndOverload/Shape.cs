using System;

namespace VirtualAndOverload
{
    public class Shape
    {
        private double _height;

        private double _width;

        public double Height { get => _height; set => _height = value; }
        public double Width { get => _width; set => _width = value; }

        public Shape()
        {
            this.Height = 10;
            this.Width = 10;
        }
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        virtual public double CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
