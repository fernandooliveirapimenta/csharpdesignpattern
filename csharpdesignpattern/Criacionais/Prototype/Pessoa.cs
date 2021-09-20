using System;
namespace csharpdesignpattern.Criacionais.Prototype
{
    public class Pessoa
    {
        public Id Id;
        public int Idade;
        public DateTime DtAniversario;
        public string Nome;

        public Pessoa CopiaRasa()
        {
            return (Pessoa)this.MemberwiseClone();
	    }

        public Pessoa CopiaProfunda()
        {
            Pessoa clone = CopiaRasa();
            clone.Id = new Id(IdNumero: Id.IdNumero);
            clone.Nome = Nome;
            return clone;
	    }
    }
}
