using System;
namespace csharpdesignpattern.Estruturais.Bridge
{
    public class Abstracao
    {
        protected InterfaceGenericaParaImplementacao _implementacao;

        public Abstracao(InterfaceGenericaParaImplementacao implementacao)
        {
            this._implementacao = implementacao;
        }

        public virtual string Operacao()
        {
            return $"Abstração: Operacao Base com {_implementacao.OperacaoComum()} ";
	
	    }
    }
}
