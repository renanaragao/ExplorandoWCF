using System;
using System.ServiceModel;

namespace ExplorandoWcf
{
    public class CalculatorService : ICalculator
    {
        public Resultado<double> Add(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) + Convert.ToDouble(n2);

            Console.WriteLine("Received Add({0},{1})", n1, n2);

            Console.WriteLine("Return: {0}", result);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Subtract(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) - Convert.ToDouble(n2);

            Console.WriteLine("Received Subtract({0},{1})", n1, n2);

            Console.WriteLine("Return: {0}", result);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Multiply(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) * Convert.ToDouble(n2);

            Console.WriteLine("Received Multiply({0},{1})", n1, n2);

            Console.WriteLine("Return: {0}", result);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Divide(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) / Convert.ToDouble(n2);

            Console.WriteLine("Received Divide({0},{1})", n1, n2);

            Console.WriteLine("Return: {0}", result);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<int> Search(int id)
        {
            return new Resultado<int>
            {
                Valor = id,
                Mensagem = "deu certo"
            };
        }

        public Resultado<DateTime> DateNow(DateTime date)
        {
            return new Resultado<DateTime>
            {
                Valor = date,
                Mensagem = "deu certo"
            };
        }
    }
}