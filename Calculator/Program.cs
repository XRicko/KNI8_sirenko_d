using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"very\" useful calculator!");

            CommonCalculator calc = new CommonCalculator();
            EngineeringCalculator engCalc = new EngineeringCalculator();

            while (true)
            {
                Console.Write("Choose type of calculator(1 - common, 2 - engineering, 3 - exit): ");
                string calcType = Console.ReadLine();

                bool isCommon = true;

                if (calcType == "1")
                    isCommon = true;
                else if (calcType == "2")
                    isCommon = false;

                try
                {
                    if (calcType == "1")
                    {
                        while (isCommon)
                        {
                            Console.Write("Choose operation(+, -, *, /, = to show result and stop, c to change calculator): ");
                            calc.Operation = Console.ReadLine();

                            if (calc.Operation == "=")
                            {
                                Console.WriteLine(calc.Result);
                                break;
                            }
                            else if (calc.Operation == "c" || calc.Operation == "C")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            calc.Number = Convert.ToDouble(Console.ReadLine());

                            calc.Run();
                        }
                    }
                    else if (calcType == "2")
                    {
                        while (!isCommon)
                        {
                            Console.Write("Choose operation(sin, cos, tan, root, log10, c to change calculator): ");
                            engCalc.Operation = Console.ReadLine();

                            if (engCalc.Operation == "c" || engCalc.Operation == "C")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            engCalc.Number = Convert.ToDouble(Console.ReadLine());

                            engCalc.Run();
                        }
                    }
                    else if (calcType == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
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
