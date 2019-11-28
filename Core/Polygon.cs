using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Polygon
    {
        public int Sides { get; set; }
        public double Lenght { get; set; }

        public double Area()
        {
            return ((Sides * Math.Pow(Lenght, 2)) / (4 * Math.Tan(360 * Math.PI / 180 / (2 * Sides))));
        }
    }
}
