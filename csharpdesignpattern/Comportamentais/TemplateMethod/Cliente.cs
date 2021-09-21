using System;
namespace csharpdesignpattern.Comportamentais.TemplateMethod
{
    public class Cliente
    {
        public static void CodigoCliente(ClasseAbstrata abstrata)
        {
            abstrata.MetodoTemplate();
        }
    }
}
