using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Figure
    {
        public double Diameter { get; set; }

        public Circle(double diameter)
        {
            Diameter = diameter;
        }

        public override double Area()
        {
            return Math.Sqrt(Diameter) * Math.PI;
        }

    }
}
