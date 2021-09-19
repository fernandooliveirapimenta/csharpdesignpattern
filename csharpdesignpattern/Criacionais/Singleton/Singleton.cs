using System;
namespace csharpdesignpattern.Criacionais.Singleton
{
    public class Singleton
    {
        private Singleton() { }


        private static Singleton _instancia;


        public static Singleton GetInstance()
		{
            if(_instancia == null)
            {
                _instancia = new Singleton();
	        }

            return _instancia;
		}

        public static void LogicaDeNegocioQualquer() 
	    {
            int a = 1, b = 3;
            Console.WriteLine($"a + b = {a + b}");
	    }

    }
}
