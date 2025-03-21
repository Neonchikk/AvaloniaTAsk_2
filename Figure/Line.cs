using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvvmSample.Figure
{
    public class Line : GeometricFigure
    {
        public double Length { get; set; }

        public Line(double x, double y, double length) : base(x, y)
        {
            Length = length;
        }

        public override (double x1, double y1, double x2, double y2) GetBoundingRectangle()
        {
            return (X, Y, X + Length, Y);
        }

        public override double GetArea()
        {
            return 0;
        }
    }
}
