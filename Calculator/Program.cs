using System;
using System.Runtime.Serialization.Formatters.Binary;
using Core;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"very\" useful calculator!");
            Console.WriteLine();

            CommonCalculator calc = new CommonCalculator();
            EngineeringCalculator engCalc = new EngineeringCalculator();
            AreaCalculator areaCalculator = new AreaCalculator();

            FileManager<CommonCalculator, BinaryFormatter> binary =
                new FileManager<CommonCalculator, BinaryFormatter>();

            while (true)
            {
                Console.WriteLine();
                Console.Write("Choose type of calculator(1 - common, 2 - engineering, 3 - area, 4 - exit): ");
                string calcType = Console.ReadLine();

                bool isCommon = calcType == "1";
                bool isArea = calcType == "3";

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
                            else if (calc.Operation.ToLower() == "c")
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
                        while (!isCommon && !isArea)
                        {
                            Console.Write("Choose operation(sin, cos, tan, root, log10, c to change calculator): ");
                            engCalc.Operation = Console.ReadLine();

                            if (engCalc.Operation.ToLower() == "c")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            engCalc.Number = Convert.ToDouble(Console.ReadLine());

                            engCalc.Run();
                            Console.WriteLine(engCalc.Result);
                        }
                    }
                    else if (calcType == "3")
                    {
                        while (isArea)
                        {
                            areaCalculator.Rect = new Rectangle();
                            areaCalculator.Triangl = new Triangle();
                            areaCalculator.Circl = new Circle();
                            areaCalculator.Trapez = new Trapezoid();

                            Console.Write("Choose figure(rect, square, triangle, circle, trapezoid): ");
                            areaCalculator.Operation = Console.ReadLine();

                            if (areaCalculator.Operation.ToLower() == "c")
                            {
                                isArea = !isArea;
                                break;
                            }

                            switch (areaCalculator.Operation)
                            {
                                case "rect":
                                    Console.Write("Enter length: ");
                                    areaCalculator.Rect.Length = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter width: ");
                                    areaCalculator.Rect.Width = Convert.ToDouble(Console.ReadLine());

                                    break;
                                case "square":
                                    Console.Write("Enter a side: ");
                                    areaCalculator.Rect.Width = areaCalculator.Rect.Length = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case "triangle":
                                    Console.Write("Choose a formula(1 - side and height, 2 - three sides, 3 - two sides and angle): ");
                                    areaCalculator.Formula = Console.ReadLine();

                                    if (areaCalculator.Formula == "1")
                                    {
                                        Console.Write("Enter a side: ");
                                        areaCalculator.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter height: ");
                                        areaCalculator.Triangl.Height = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else if (areaCalculator.Formula == "2")
                                    {
                                        Console.Write("Enter 1st side: ");
                                        areaCalculator.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 2st side: ");
                                        areaCalculator.Triangl.SideB = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 3rd side: ");
                                        areaCalculator.Triangl.SideC = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else if (areaCalculator.Formula == "3")
                                    {
                                        Console.Write("Enter 1st side: ");
                                        areaCalculator.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 2nd side: ");
                                        areaCalculator.Triangl.SideB = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter an angle between them: ");
                                        areaCalculator.Triangl.Angle = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input");
                                    }

                                    break;
                                case "circle":
                                    Console.Write("Enter a radius: ");
                                    areaCalculator.Circl.Radius = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case "trapezoid":
                                    Console.Write("Enter 1st base: ");
                                    areaCalculator.Trapez.BaseA = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter 2nd base: ");
                                    areaCalculator.Trapez.BaseB = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter height: ");
                                    areaCalculator.Trapez.Height = Convert.ToDouble(Console.ReadLine());

                                    break;
                            }

                            areaCalculator.Run();
                            Console.WriteLine(areaCalculator.Result);
                        }
                    }
                    else if (calcType == "4")
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
