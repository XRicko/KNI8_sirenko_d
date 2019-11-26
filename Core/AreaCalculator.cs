namespace Core
{
    public class AreaCalculator : AbsCalculator
    {
        public string Formula { get; set; }
        public Rectangle Rect { get; set; }
        public Triangle Triangl { get; set; }
        public Circle Circl { get; set; }
        public Trapezoid Trapez { get; set; }

        public override void Run()
        {
            switch (Operation)
            {
                case "rect":
                    Result = Rect.Area();
                    break;
                case "square":
                    Result = Rect.Area();
                    break;
                case "triangle":
                    Result = Triangl.Area(Formula);
                    break;
                case "circle":
                    Result = Circl.Area();
                    break;
                case "trapezoid":
                    Result = Trapez.Area();
                    break;
            }
        }
    }
}
