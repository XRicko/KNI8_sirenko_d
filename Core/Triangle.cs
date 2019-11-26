using System;

namespace Core
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }
        public double Angle { get; set; }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public double Area(string formula)
        {
            double res = 0;

            switch (formula)
            {
                case "1":
                    res = SideA * Height / 2;
                    break;
                case "2":
                    double p = Perimeter() / 2;
                    res = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                    break;
                case "3":
                    res = SideA * SideB * Angle / 2;
                    break;
            }

            return res;
        }
    }
}
