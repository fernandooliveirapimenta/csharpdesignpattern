using System;
namespace csharpdesignpattern.Comportamentais.Strategy
{
    public class ImplStrategyB : IStrategy
    {
        public double calcular(double a, double b)
        {
            double r = a - b;
            Console.WriteLine($"calculo b = {r}\n");
            return r;
        }
    }
}
