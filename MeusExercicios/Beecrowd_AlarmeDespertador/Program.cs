using System;

namespace Beecrowd_AlarmeDespertador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int h1;
            int m1;
            int h2;
            int m2;
            int t1;
            int t2;
            int i;
            int resto = 0;
            
            while (true)
            {
                linha = Console.ReadLine();
                var vetorLinha = linha.Split(' ');

                h1 = int.Parse(vetorLinha[0]);
                m1 = int.Parse(vetorLinha[1]);
                h2 = int.Parse(vetorLinha[2]);
                m2 = int.Parse(vetorLinha[3]);

                //t1 = (h1 * 60) + m1;
                //t2 = (h2 * 60) + m2;

                if ((h1 < h2) || ((h1 == h2) && (m1 < m2)))
                    {
                        resto = ((h2*60)+m2) - ((h1*60)+m1);
                        Console.WriteLine(resto);
                    }
                if ((h2 < h1) || ((h1 == h2) && (m2 < m1)))
                {
                    resto = 1440-((h1 *60)+m1);
                    resto = resto + (h2 *60)+m2;


                    Console.WriteLine(resto);
                }
                else if (h1 == 0 && h2 == 0 && m1 == 0 && m2 == 0)
                {
                    break;
                }
            }
            }
        }
    }

        

