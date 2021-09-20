using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class Cliente
    {
        public void CodigoDoCliente(Abstracao abstracao)
        {
            Console.Write(abstracao.Operacao());
        }
    }
}
