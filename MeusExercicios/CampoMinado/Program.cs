using System;

namespace CampoMinado
{
    internal class Program
    {
        static int[,] jogo;
        const int linhas = 8, colunas = 6;
        static void Main(string[] args)
        {
            jogo = new int[linhas, colunas];
            Random numero = new Random();

            InicializarTabuleiro();
        }
        static void InicializarTabuleiro()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    jogo[i, j] = 0;
                }
            }
        }
    }
}
