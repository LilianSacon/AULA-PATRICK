using System;

namespace Beecrowd_ASociedadeDoAnel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;
            string linha;
            int anao = 0;
            int elfo = 0;
            int humano = 0;
            int mago = 0;
            int hobbit = 0;

            int.TryParse(Console.ReadLine(), out N);

            for (i = 0; i < N; i++)
            {
                linha = Console.ReadLine();
                var texto = linha.Split(' ');

                if  (texto[1] == "A")
                {
                    anao++;
                }
                else if (texto[1] == "E")
                {
                    elfo++;
                }
                else if (texto[1] == "H")
                {
                    humano++;
                }
                else if (texto[1] == "M")
                {
                    mago++;
                }
                else if (texto[1] == "X")
                {
                    hobbit++;
                }
            }
            Console.WriteLine(hobbit + " Hobbit(s)");
            Console.WriteLine(humano + " Humano(s)");
            Console.WriteLine(elfo + " Elfo(s)");
            Console.WriteLine(anao + " Anao(s)");
            Console.WriteLine(mago + " Mago(s)");
        }
    }
}
