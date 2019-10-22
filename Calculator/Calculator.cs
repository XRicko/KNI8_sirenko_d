namespace Calculator
{
    abstract class Calculator
    {
        public string Operation { get; set; }
        public double Number { get; set; }
        public double Result { get; protected set; } = 0;

        public abstract void Run();
    }
}
