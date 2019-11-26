using System;

namespace Core
{
    [Serializable]
    public class EngineeringCalculator : AbsCalculator
    {
        public void Sinus()
        {
            Result = Math.Sin(Number);
        }

        public void Cosinus()
        {
            Result = Math.Cos(Number);
        }

        public void Tangens()
        {
            Result = Math.Tan(Number);
        }

        public void Root()
        {
            Result = Math.Sqrt(Number);
        }

        public void Logarithm10()
        {
            Result = Math.Log10(Number);
        }

        public override void Run()
        {
            switch (Operation)
            {
                case "sin":
                    Sinus();
                    break;
                case "cos":
                    Cosinus();
                    break;
                case "tan":
                    Tangens();
                    break;
                case "root":
                    Root();
                    break;
                case "log10":
                    Logarithm10();
                    break;
                default:
                    break;
            }
        }
    }
}
