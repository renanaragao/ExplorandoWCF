using System;

namespace ExplorandoWcf.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new CalculatorService.CalculatorClient();

            Console.WriteLine();
            Console.WriteLine("4 + 4 = {0}", service.Add(4, 4));
            Console.WriteLine();
            Console.WriteLine("4 * 4 = {0}", service.Multiply(4, 4));
            Console.WriteLine();
            Console.WriteLine("4 - 4 = {0}", service.Subtract(4, 4));
            Console.WriteLine();
            Console.WriteLine("4 / 4 = {0}", service.Divide(4, 4));
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
