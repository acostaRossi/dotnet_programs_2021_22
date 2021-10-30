using System;

namespace VirtualAndOverload
{
    class Program
    {   
        static void Main(string[] args)
        {
            double CalcShapesArea(Shape[] shapes)
            {
                double area = 0;

                foreach (var shape in shapes)
                {
                    area += shape.CalcArea();
                }

                return area;
            }

            Shape t = new Triangle(10, 20);
            
            Shape r1 = new Rectangle(10, 20);

            Shape r2 = new Rectangle(20, 30);

            double area = CalcShapesArea(new Shape[] { t, r1, r2 });

            Console.WriteLine($"Area is: { area }");
        }
    }
}


//double CalcShapesArea(Triangle[] triangles, Rectangle[] rectangles)
//{
//    double area = 0;

//    foreach (var rectangle in rectangles)
//    {
//        area += rectangle.CalcArea();
//    }

//    foreach (var triangle in triangles)
//    {
//        area += triangle.CalcArea();
//    }

//    return area;
//}