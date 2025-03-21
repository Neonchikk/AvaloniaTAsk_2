using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvvmSample.Figure
{
    public abstract class GeometricFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public GeometricFigure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public abstract (double x1, double y1, double x2, double y2) GetBoundingRectangle();
        public abstract double GetArea();
    }
}
