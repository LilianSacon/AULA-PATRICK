using System;

namespace jogovelha
{
    internal class Program

    {
        static int[,] jogo;
        const int linhas = 3, colunas = 3;
        static void Main(string[] args)
        {
            jogo = new int[linhas, colunas];

            InicializarTabuleiro();
            
            int quemjoga = 1;
            bool continuarjogando = true;

            while (continuarjogando) //laço do jogo
            {
                //imprimir tabuleiro - console.writeline
                ImprimirTabuleiro();
                //ler quem joga - quemjoga alterna entre jogador 1 e 2 - sempre que jogada for impar ou par é um jogador
                //registrar posição de jogada - ABC 123 só continua se registrou posição jogada 
                //checar se ganhou - se não ganhou ver se tem posição livre para jogar
                //checar empate - 
                //alterar quem joga
                continuarjogando = false;
            }
        }
        static void ImprimirTabuleiro()
        {
            Console.Write("Tabuleiro\r\n");
            
            for (int i = 0; i < linhas; i++)
                
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (jogo[i, j] == 0)
                    {
                        Console.Write("   ");
                    }
                    else if (jogo[i, j] == 1)
                    {
                        Console.Write(" X ");

                    }
                    else if (jogo[i, j] == 2)
                    {
                        Console.Write(" O ");
                    }

                    if (j == 0 || j == 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("---+---+---");
                }
            }
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


