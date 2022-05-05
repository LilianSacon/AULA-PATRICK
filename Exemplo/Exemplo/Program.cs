using System;

namespace Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerointeiro = 1234;
            short numeropequeno;
            long numerogrande;

            double numeroflutuante = 123.00;
            float numerofloat = 123.00f;
            decimal numeroMuitoGrande = 1234.5453m;

            string nome = "texto";
            bool verdadeiroFalso = false;

            char carac = 'A'(recebe somente 1 caracter);
            var nome = "1f";

            while (/* expressão */) ;

            Console.ReadLine("sempre devolve uma string");

            //Exemplos:
            int contador = 0;
            while (contador <= 100)
            { 
                Console.WriteLine (contador); 
                contador++; 
            }
            var resultado2 = 10 % 3;
            for (contador = 0; contador <= 100; contador++)
            { 
                if (contador % 2 == 0)
                { Console.WriteLine("" + contador + "eh par");
                }

        }
    }
}
