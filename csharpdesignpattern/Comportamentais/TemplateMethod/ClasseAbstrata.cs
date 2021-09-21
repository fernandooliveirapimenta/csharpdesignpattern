using System;
namespace csharpdesignpattern.Comportamentais.TemplateMethod
{
    public abstract class ClasseAbstrata
    {
        public void MetodoTemplate() 
	    {
            this.OperacaoBase1();
            this.OperacaoRequerida1();
            this.OperacaoBase2();
            this.MetodoGanchoHook1();
            this.OperacaoRequerida2();
            this.OperacaoBase3();
            this.MetodoGanchoHook2();
		}

        protected void OperacaoBase1() 
	    {
            Console.WriteLine($"{this} falou: Estou fazendo a maior parte do trabalho");
	    }

        protected void OperacaoBase2() 
	    {
            Console.WriteLine($"{this} falou: Mas eu vou deixar as subclasses override algumas operacoes");
	    }

        protected void OperacaoBase3() 
	    {
            Console.WriteLine($"{this} falou: Mas estou fazendo a maior parte do trabalho de qualquer forma");
	    }

        protected abstract void OperacaoRequerida1();

        protected abstract void OperacaoRequerida2();

        protected virtual void MetodoGanchoHook1() { }

        protected virtual void MetodoGanchoHook2() { }
    }
}
