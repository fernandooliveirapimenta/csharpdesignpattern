using System;
namespace csharpdesignpattern.Criacionais.Prototype
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Idade = 25;
            p1.DtAniversario = Convert.ToDateTime("1995-10-30");
            p1.Nome = "Fernando Pimenta";
            p1.Id = new Id(333);

            Pessoa p2 = p1.CopiaRasa();
            Pessoa p3 = p1.CopiaProfunda();
            
        }
    }
}
