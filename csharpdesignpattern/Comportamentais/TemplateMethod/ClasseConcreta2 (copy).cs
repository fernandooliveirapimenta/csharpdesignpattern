using System;
namespace csharpdesignpattern.Comportamentais.TemplateMethod
{
    public class ClasseConcreta2 : ClasseAbstrata
    {

        protected override void OperacaoRequerida1()
        {
            Console.WriteLine("ClasseConcreta2 falou: Implementando Operacao1");

        }

        protected override void OperacaoRequerida2()
        {
            Console.WriteLine("ClasseConcreta2 falou: Implementando Operacao2");
        }

        protected override void MetodoGanchoHook1()
        {

            Console.WriteLine("ClasseConcreta2 falou: Overridden Hook1");

        }
    }
}
