using System;

namespace Calculator
{
    [Serializable]
    public class CommonCalculator : Calculator
    {
        public void Addition()
        {
            Result += Number;
        }

        public void Subtraction()
        {
            Result -= Number;
        }

        public void Multiplication()
        {
            Result *= Number;
        }

        public void Division()
        {
            Result /= Number;
        }

        public override void Run()
        {
            switch (Convert.ToChar(Operation))
            {
                case '+':
                    Addition();
                    break;
                case '-':
                    Subtraction();
                    break;
                case '*':
                    Multiplication();
                    break;
                case '/':
                    Division();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
