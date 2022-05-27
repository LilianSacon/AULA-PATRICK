using System;

namespace Beecrowd_FloresFlorescemDaFranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string frase1;
            char letra;
            int i;
            int j;
            bool todasiguais;
            string palavra;

            for (i = 0; i < 100; i++)
            {
                frase = Console.ReadLine();

                if (frase == "*")
                    break;
                {
                    frase1 = frase.ToUpper();
                    var vetorLinha = frase1.Split(' ');
                    todasiguais = true;
                    palavra = vetorLinha[0];
                    letra = palavra[0];

                    for (j = 0; j < vetorLinha.Length; j++)
                    {
                        palavra = vetorLinha[j];

                        if (palavra[0] != letra)
                        {
                            todasiguais = false;
                        }
                    }
                }
                if (todasiguais)
                    Console.WriteLine("Y");
                else
                    Console.WriteLine("N");

            }
        }
    }
}
