using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvvmSample.Figure
{
    public class Ellipse : GeometricFigure
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double x, double y, double majorAxis, double minorAxis) : base(x, y)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public override (double x1, double y1, double x2, double y2) GetBoundingRectangle()
        {
            return (X - MajorAxis, Y - MinorAxis, X + MajorAxis, Y + MinorAxis);
        }

        public override double GetArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }
    }
}
