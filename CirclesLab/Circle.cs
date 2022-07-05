using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesLab
{
    internal class Circle
    {
        public double radius;

        //constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }

        //methods
        public double CalculateCircumference()
        {
            double r = radius * 2 * Math.PI;
            return r;
        }
        public double CalculateArea()
        {
            double a = Math.PI * radius * radius;
            return a;
        }
        private string FormatNumber(double x)
        {
            string format = string.Format("{0:0.00}", x);
            return format;
        }
        public string CalculateFormattedCircumference()
        {
            string formatCircum = FormatNumber(CalculateCircumference());
            return formatCircum;
        }
        public string CalculateFormattedArea()
        {
            string area = FormatNumber(CalculateArea());
            return area;
        }
    }
}
