using System;

namespace Beecrowd_GastoDeCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            int velocidade;
            double media = 12;
            double litros;

            int.TryParse(Console.ReadLine(), out tempo);
            int.TryParse(Console.ReadLine(), out velocidade);

            litros = (tempo * velocidade) / media;
            Console.WriteLine(litros.ToString("F3")
                                    );
        }
    }
}
