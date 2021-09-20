using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class ExtendendoFuncionalidadesDaAbstracao : Abstracao
    {
        public ExtendendoFuncionalidadesDaAbstracao(
	       InterfaceGenericaParaImplementacao implementacao) : base(implementacao)
        {
        }

        public override string Operacao()
        {
	   
            return $"ExtendendoFuncionalidadesDaAbstracao: com {base._implementacao.OperacaoComum()}";
        }
    }
}
