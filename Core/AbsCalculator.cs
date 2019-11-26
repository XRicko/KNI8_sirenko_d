using System;

namespace Core
{
    [Serializable]
    public abstract class AbsCalculator
    {
        public string Operation { get; set; }
        public double Number { get; set; }
        public double Result { get; set; } = 0;

        public abstract void Run();
    }
}
