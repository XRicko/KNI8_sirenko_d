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

            CommonCalculator commonCalc = new CommonCalculator();
            EngineeringCalculator engineeringCalc = new EngineeringCalculator();
            AreaCalculator areaCalc = new AreaCalculator();
            FileManager fileManager = new FileManager();

            CommonCalculator oldCommCalc = fileManager.Desialization<CommonCalculator>("common_calc.xml");
            EngineeringCalculator oldEnginCalc = fileManager.Desialization<EngineeringCalculator>("engineering_calc.xml");
            AreaCalculator oldAreaCalc = fileManager.Desialization<AreaCalculator>("area_calc.xml");

            Console.WriteLine($"Last result of common calculator: {oldCommCalc.Result}");
            Console.WriteLine($"Last result of engineering calculator: {oldEnginCalc.Result}");
            Console.WriteLine($"Last result of area calculator: {oldAreaCalc.Result}");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Choose type of calculator(1 - common, 2 - engineering, 3 - area, 4 - exit): ");
                string calcType = Console.ReadLine();

                bool isCommon = calcType == "1";
                bool isArea = calcType == "3";
                bool commonUsed = false;
                bool engineeringUsed = false;
                bool areaUsed = false;

                try
                {
                    if (calcType == "1")
                    {
                        commonUsed = true;

                        while (isCommon)
                        {
                            Console.Write("Choose operation(+, -, *, /, = to show result and stop, c to change calculator): ");
                            commonCalc.Operation = Console.ReadLine();

                            if (commonCalc.Operation == "=")
                            {
                                Console.WriteLine(commonCalc.Result);
                                Console.WriteLine();
                                break;
                            }
                            else if (commonCalc.Operation.ToLower() == "c")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            commonCalc.Number = Convert.ToDouble(Console.ReadLine());

                            commonCalc.Run();
                        }
                    }
                    else if (calcType == "2")
                    {
                        engineeringUsed = true;

                        while (!isCommon && !isArea)
                        {
                            Console.Write("Choose operation(sin, cos, tan, root, log10, c to change calculator): ");
                            engineeringCalc.Operation = Console.ReadLine();

                            if (engineeringCalc.Operation.ToLower() == "c")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            engineeringCalc.Number = Convert.ToDouble(Console.ReadLine());

                            engineeringCalc.Run();
                            Console.WriteLine(engineeringCalc.Result);
                            Console.WriteLine();
                        }
                    }
                    else if (calcType == "3")
                    {
                        areaUsed = true;

                        while (isArea)
                        {
                            areaCalc.Rect = new Rectangle();
                            areaCalc.Triangl = new Triangle();
                            areaCalc.Circl = new Circle();
                            areaCalc.Trapez = new Trapezoid();
                            areaCalc.Polyg = new Polygon();

                            Console.Write("Choose figure(rect, square, triangle, circle, trapezoid, polygon, c to change calc): ");
                            areaCalc.Operation = Console.ReadLine();

                            if (areaCalc.Operation.ToLower() == "c")
                            {
                                isArea = !isArea;
                                break;
                            }

                            switch (areaCalc.Operation)
                            {
                                case "rect":
                                    Console.Write("Enter length: ");
                                    areaCalc.Rect.Length = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter width: ");
                                    areaCalc.Rect.Width = Convert.ToDouble(Console.ReadLine());

                                    break;
                                case "square":
                                    Console.Write("Enter a side: ");
                                    areaCalc.Rect.Width = areaCalc.Rect.Length = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case "triangle":
                                    Console.Write("Choose a formula(1 - side and height, 2 - three sides, 3 - two sides and angle): ");
                                    areaCalc.Formula = Console.ReadLine();

                                    if (areaCalc.Formula == "1")
                                    {
                                        Console.Write("Enter a side: ");
                                        areaCalc.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter height: ");
                                        areaCalc.Triangl.Height = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else if (areaCalc.Formula == "2")
                                    {
                                        Console.Write("Enter 1st side: ");
                                        areaCalc.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 2st side: ");
                                        areaCalc.Triangl.SideB = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 3rd side: ");
                                        areaCalc.Triangl.SideC = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else if (areaCalc.Formula == "3")
                                    {
                                        Console.Write("Enter 1st side: ");
                                        areaCalc.Triangl.SideA = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter 2nd side: ");
                                        areaCalc.Triangl.SideB = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter an angle between them: ");
                                        areaCalc.Triangl.Angle = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input");
                                    }

                                    break;
                                case "circle":
                                    Console.Write("Enter a radius: ");
                                    areaCalc.Circl.Radius = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case "trapezoid":
                                    Console.Write("Enter 1st base: ");
                                    areaCalc.Trapez.BaseA = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter 2nd base: ");
                                    areaCalc.Trapez.BaseB = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter height: ");
                                    areaCalc.Trapez.Height = Convert.ToDouble(Console.ReadLine());

                                    break;
                                case "polygon":
                                    Console.Write("Enter number of sides: ");
                                    areaCalc.Polyg.Sides = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter lenhgt: ");
                                    areaCalc.Polyg.Lenght = Convert.ToDouble(Console.ReadLine());

                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }

                            areaCalc.Run();
                            Console.WriteLine(areaCalc.Result);
                            Console.WriteLine();
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

                    if (commonUsed)
                    {
                        fileManager.Serialization(commonCalc, "common_calc.xml");
                    }
                    if (engineeringUsed)
                    {
                        fileManager.Serialization(engineeringCalc, "engineering_calc.xml");
                    }
                    if (areaUsed)
                    {
                        fileManager.Serialization(areaCalc, "area_calc.xml");
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
