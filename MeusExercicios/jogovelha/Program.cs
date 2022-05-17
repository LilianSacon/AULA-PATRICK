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
            
            int contador = 0;

            int quemjoga = 1;
            bool continuarjogando = true;
            bool checarGanhador;
            bool checarEmpate;
            string posicaoJogada;

            while (continuarjogando) //laço do jogo
            {

                //imprimir tabuleiro - console.writeline
                ImprimirTabuleiro();

                //ler quem joga - quemjoga alterna entre jogador 1 e 2 - sempre que jogada for impar ou par é um jogador
                posicaoJogada = LerPosicaoJogador(quemjoga);

                //registrar posição de jogada - ABC 123 só continua se registrou posição jogada 
                RegistrarPosicaoJogador(quemjoga, posicaoJogada);

                //checar se ganhou - se não ganhou ver se tem posição livre para jogar
                checarGanhador = ChecarGanhador(quemjoga);


                //checar empate - 
                if(checarGanhador == false)
                {
                    checarEmpate = ChecarEmpate();
                    if(checarEmpate == true)
                    {
                        Console.WriteLine("Houve Empate!");
                        continuarjogando = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Jogador {quemjoga} é o vencedor!");
                    continuarjogando=false;
                }

                //alterar quem joga
                if(quemjoga == 1)
                {
                    quemjoga = 2;
                }
                else  if(quemjoga == 2)
                {
                    quemjoga = 1;
                }


                //continuarjogando = false;
            }
            ImprimirTabuleiro();
        }

        static bool ChecarEmpate()
        {
            for(int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (jogo[i,j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool ChecarGanhador(int quemjoga)
        {
            if (jogo[0, 0] == quemjoga && jogo[0, 1] == quemjoga && jogo[0, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[1, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[1, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[2, 0] == quemjoga && jogo[2, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 0] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 1] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 1] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 2] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void RegistrarPosicaoJogador(int quemjoga, string posicaoJogada)
        {
            int x, y;
            var posicoes = posicaoJogada.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            jogo[x, y] = quemjoga;

        }

        static string LerPosicaoJogador(int quemjoga)
        {
            Console.WriteLine($"Jogador {quemjoga} é a sua vez! Escolha uma posição:");
            string linha;
            int x, y;
            /*
             * 0 0 | 0 1 | 0 2
             * 1 0 | 1 1 | 1 2
             * 2 0 | 2 1 | 2 2
             */
            linha = Console.ReadLine(); //0 2
            var posicoes = linha.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            if(jogo[x,y] ==0)
            {
                // posição não jogada
                return linha;
            }
            return "";
        }
        static void ImprimirTabuleiro()
        {
            Console.WriteLine("Tabuleiro"); 

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


