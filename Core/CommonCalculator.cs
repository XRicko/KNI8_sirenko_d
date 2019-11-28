using System;

namespace Core
{
    [Serializable]
    public class CommonCalculator : AbsCalculator
    {
        private void Addition()
        {
            Result += Number;
        }

        private void Subtraction()
        {
            Result -= Number;
        }

        private void Multiplication()
        {
            Result *= Number;
        }

        private void Division()
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
                    break;
            }
        }
    }
}
