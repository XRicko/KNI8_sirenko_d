using System;

namespace Core
{
    [Serializable]
    public class EngineeringCalculator : AbsCalculator
    {
        private void Sinus()
        {
            Result = Math.Sin(Number);
        }

        private void Cosinus()
        {
            Result = Math.Cos(Number);
        }

        private void Tangens()
        {
            Result = Math.Tan(Number);
        }

        private void Root()
        {
            Result = Math.Sqrt(Number);
        }

        private void Logarithm10()
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
