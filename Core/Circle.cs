using System;

namespace Core
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
