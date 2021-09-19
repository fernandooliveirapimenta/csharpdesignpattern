using System;
namespace csharpdesignpattern.Comportamentais.Strategy
{
    public class Teste
    {

        static void Main(string[] args)
        {
            IStrategy a = new ImplStrategyA();
            IStrategy b = new ImplStrategyB();

            var motor = new MotorContextoStrategy(a);
            motor.ExecutarCalculoFacade();


            motor.SetEstrategia(b);
            motor.ExecutarCalculoFacade();
	    }
    }
}
