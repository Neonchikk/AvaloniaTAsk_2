using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvvmSample.Figure
{
    public class Point : GeometricFigure
    {
        public Point(double x, double y) : base(x, y) { }

        public override (double x1, double y1, double x2, double y2) GetBoundingRectangle()
        {
            return (X, Y, X, Y);
        }

        public override double GetArea()
        {
            return 0;
        }
    }
}
