namespace Core
{
    public class Trapezoid
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return (BaseA + BaseB) / 2 * Height;
        }
    }
}
