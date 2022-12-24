using System;
using System.Collections.Generic;
using System.Text;

namespace Task1and2
{
    internal class Calculator : IAddition
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public double Add(params double[] numbers)
        {
            double result = 0;

            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
            }

            Logger.Event("Числа суммированы, результат: " + result);
            return result;
        }
    }
}
