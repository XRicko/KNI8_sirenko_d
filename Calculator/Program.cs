using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation;
            double number;
            double result = 0;

            Console.WriteLine("Welcome to the \"very\" useful calculator!");

            while (true)
            {
                try
                {
                    Console.Write("Choose operation(+, -, *, /, = to show result and stop): ");
                    operation = Convert.ToChar(Console.ReadLine());

                    if (operation == '=')
                    {
                        Console.WriteLine(result);
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("Enter a number: ");
                    number = Convert.ToDouble(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            result += number;
                            break;
                        case '-':
                            result -= number;
                            break;
                        case '*':
                            result *= number;
                            break;
                        case '/':
                            result /= number;
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
