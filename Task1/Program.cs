using System;
using System.Collections.Generic;

namespace Task1and2
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            try
            {
                var calculator = new Calculator(Logger);
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine(calculator.Add(number1, number2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка! - {0}", e);
            }
        }
    }
}
