using System;
namespace csharpdesignpattern.Comportamentais.TemplateMethod
{
    public class ClasseConcreta1 : ClasseAbstrata
    {

        protected override void OperacaoRequerida1()
        {
            Console.WriteLine("ClasseConcreta1 falou: Implementando Operacao1");

        }

        protected override void OperacaoRequerida2()
        {
            Console.WriteLine("ClasseConcreta1 falou: Implementando Operacao2");
        }

    }
}
