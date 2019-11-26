namespace Core
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
        public double Area()
        {
            return Length * Width;
        }
    }
}
