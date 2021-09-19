using System;
namespace csharpdesignpattern.Comportamentais.Strategy
{
    public class ImplStrategyA : IStrategy
    {
        public double calcular(double a, double b)
        {
            double r = a + b;
            Console.Write($"calculo a  = {r}\n");
            return r;
        }
    }
}
