using System;
using System.IO;
using System.Xml.Serialization;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"very\" useful calculator!");
            Console.WriteLine();

            CommonCalculator calc = new CommonCalculator();
            EngineeringCalculator eCalc = new EngineeringCalculator();

            XmlSerializer formatter = new XmlSerializer(typeof(CommonCalculator));
            XmlSerializer aformatter = new XmlSerializer(typeof(EngineeringCalculator));

            using (FileStream fs = File.OpenRead("calculator.xml"))
            {
                Calculator newCalc = (CommonCalculator)formatter.Deserialize(fs);

                Console.WriteLine($"Last result of common calculator: {newCalc.Result}");
            }

            using (FileStream fs = File.OpenRead("EngineeringCalculator.xml"))
            {
                EngineeringCalculator newECalc = (EngineeringCalculator)aformatter.Deserialize(fs);

                Console.WriteLine($"Last result of engineering calculator: {newECalc.Result}");
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Choose type of calculator(1 - common, 2 - engineering, 3 - exit): ");
                string calcType = Console.ReadLine();

                bool isCommon = calcType == "1";

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
                        while (!isCommon)
                        {
                            Console.Write("Choose operation(sin, cos, tan, root, log10, c to change calculator): ");
                            eCalc.Operation = Console.ReadLine();

                            if (eCalc.Operation.ToLower() == "c")
                            {
                                isCommon = !isCommon;
                                break;
                            }

                            Console.Write("Enter a number: ");
                            eCalc.Number = Convert.ToDouble(Console.ReadLine());

                            eCalc.Run();
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

            using (FileStream fs = new FileStream("calculator.xml", FileMode.Create))
            {
                formatter.Serialize(fs, calc);
            }

            using (FileStream fs = new FileStream("EngineeringCalculator.xml", FileMode.Create))
            {
                aformatter.Serialize(fs, eCalc);
            }
        }
    }
}
