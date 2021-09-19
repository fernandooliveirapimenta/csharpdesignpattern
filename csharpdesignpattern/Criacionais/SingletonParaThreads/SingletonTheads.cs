using System;
namespace csharpdesignpattern.Criacionais.SingletonParaThreads
{
    public class SingletonTheads
    {
        private SingletonTheads()
        {
        }

        private static SingletonTheads _instancia;
        private static readonly object _lock = new object();

        public static SingletonTheads GetInstance(string value)
        { 

            if(_instancia == null)
            {
                lock (_lock)
                { 
                    if(_instancia == null)
                    {
                        _instancia = new SingletonTheads();
                        _instancia.Value = value;
		            }
		        }
		    }

            return _instancia;

		}

        public string Value { get; set; }
    }
}
