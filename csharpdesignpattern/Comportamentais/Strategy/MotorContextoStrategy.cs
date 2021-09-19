using System;
namespace csharpdesignpattern.Comportamentais.Strategy
{
    public class MotorContextoStrategy
    {

        private IStrategy _estrategia;

        public MotorContextoStrategy() { }

        public MotorContextoStrategy(IStrategy estrategia) 
		{
            this._estrategia = estrategia;
	    }


        public void SetEstrategia(IStrategy estrategia)
        {
            this._estrategia = estrategia;
	    }

        public void ExecutarCalculoFacade()
        {
            Console.WriteLine($"Executando calculo via motor {_estrategia} \n");

            double resultado = _estrategia.calcular(a:60, b:30);

            Console.WriteLine($"Finalizando com resultado {resultado} \n");
	    }
    }
}
