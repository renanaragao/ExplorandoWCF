using System;

namespace ExplorandoWcf.WebHttp
{
    public class CalculatorService : ICalculator
    {
        public Resultado<double> Add(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) + Convert.ToDouble(n2);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Subtract(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) - Convert.ToDouble(n2);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Multiply(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) * Convert.ToDouble(n2);

            return new Resultado<double>
            {
                Valor = result,
                Mensagem = "deu certo"
            };
        }

        public Resultado<double> Divide(string n1, string n2)
        {
            var result = Convert.ToDouble(n1) / Convert.ToDouble(n2);

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

        public Resultado<DateTime> DateNow(string date)
        {
            return new Resultado<DateTime>
            {
                Valor = Convert.ToDateTime(date),
                Mensagem = "deu certo"
            };
        }

        public Resultado<DateTime> AddDays(Resultado<DateTime> resultado)
        {
            return new Resultado<DateTime>
            {
                
                Mensagem = "deu certo",
                Valor = DateTime.Now.AddDays(1)

            };
        }
    }
}