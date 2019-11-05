using System;

namespace Calculator
{
    public abstract class Calculator
    {
        public string Operation { get; set; }
        public double Number { get; set; }
        public double Result { get; set; } = 0;

        public abstract void Run();
    }
}
