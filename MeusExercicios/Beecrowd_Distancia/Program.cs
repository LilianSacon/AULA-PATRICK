using System;

namespace Beecrowd_Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Km;
            int tempo;

            int.TryParse(Console.ReadLine(), out Km);
            tempo = (Km * 2) / 1;
            Console.WriteLine(tempo + " minutos");

        }
    }
}
