using System;
namespace csharpdesignpattern.Comportamentais.TemplateMethod
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mesmo código do cliente pode funcionar com subclasses diferentes");
            Cliente.CodigoCliente(new ClasseConcreta1());

            Console.Write("\n");
            
            Console.WriteLine("Mesmo código do cliente pode funcionar com subclasses diferentes");
            Cliente.CodigoCliente(new ClasseConcreta2());
        }
    }
}
