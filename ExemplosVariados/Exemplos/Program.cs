using System;

namespace Exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerointeiro = 1234;
            short numeropequeno;
            long numerogrande;

            double numeroFlutuante = 123.00;
            float numeroFloat = 123.00f;
            decimal numeroMuitogrande = 1234.5453m;

            string nome = "texto";
            bool VerdadeiroFalso = false;

            char carac = 'A'(recebe somente 1 caracter);

            var nome = "1f";

            while (/* expressão */) ;

            
            Console.ReadLine("Sempre devolve uma string");

            //Exemplos:
            int contador = 0;
            while(contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
            var resultado2 = 10 % 3;
            for ( contador = 0 ; contador <= 100 ; contador++)
            { 
                if (contador % 2 == 0)
                {
                    Console.WriteLine("" + contador + "eh par");
                }
            }

        }
    }
}
