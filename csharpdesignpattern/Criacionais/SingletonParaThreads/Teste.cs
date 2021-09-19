using System;
using System.Threading;

namespace csharpdesignpattern.Criacionais.SingletonParaThreads
{
    public class Teste
    {

        static void Main(string[] args) {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "Se vc ver o msm valor o singleton foi reusado e esta correto",
                "Se vc ver o valor diferente esta ERRADO!",
                "RESULTADO:"
                );

            Thread p1 = new Thread(() =>
            {

                TesteSingleton("CORINTHIANS");

            });

            Thread p2 = new Thread(() =>
            {

                TesteSingleton("PALMEIRAS");

            });

            p1.Start();
            p2.Start();

            p1.Join();
            p2.Join();

        }

        public static void TesteSingleton(string value) 
	    {
            SingletonTheads s = SingletonTheads.GetInstance(value);
            Console.WriteLine(s.Value);
	
	    }
    }
}
