using System;

namespace Calculator
{
    [Serializable]
    public class EngineeringCalculator : Calculator
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
                    Console.WriteLine(Result);
                    break;
                case "cos":
                    Cosinus();
                    Console.WriteLine(Result);
                    break;
                case "tan":
                    Tangens();
                    Console.WriteLine(Result);
                    break;
                case "root":
                    Root();
                    Console.WriteLine(Result);
                    break;
                case "log10":
                    Logarithm10();
                    Console.WriteLine(Result);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
