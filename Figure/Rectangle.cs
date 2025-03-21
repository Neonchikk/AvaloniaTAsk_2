using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvvmSample.Figure
{
    public class Rectangle : GeometricFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override (double x1, double y1, double x2, double y2) GetBoundingRectangle()
        {
            return (X, Y, X + Width, Y + Height);
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
