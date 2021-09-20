using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class ImplementacaoConcretaB : InterfaceGenericaParaImplementacao
    {

        public string OperacaoComum()
        {
            return $"{this}: o resultado da plataforma B.\n";
        }
    }
}
