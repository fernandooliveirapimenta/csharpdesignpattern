using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class ImplementacaoConcretaA : InterfaceGenericaParaImplementacao
    {
        public string OperacaoComum()
        {
            return $"{this}: o resultado da plataforma A.\n"  ;
        }
    }
}
