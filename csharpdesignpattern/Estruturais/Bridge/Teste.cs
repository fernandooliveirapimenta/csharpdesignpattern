using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class Teste
    {
        static void Main(string[] args)
        {

           Cliente cliente = new Cliente();

           var implA =  new ImplementacaoConcretaA();
           Abstracao abstracao = new Abstracao(implementacao: implA);
           cliente.CodigoDoCliente(abstracao);

           Console.WriteLine();


           var implB =  new ImplementacaoConcretaB();
           abstracao = new ExtendendoFuncionalidadesDaAbstracao(implementacao: implB);
           cliente.CodigoDoCliente(abstracao);
	    }
    }
}
