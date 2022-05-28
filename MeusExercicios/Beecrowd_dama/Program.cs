using System;

namespace Beecrowd_dama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int x1;
            int y1;
            int x2;
            int y2;
            int calcx;
            int calcy;

            while (true)
            {
                linha = Console.ReadLine();
                var vetorLinha = linha.Split(' ');

                x1 = int.Parse(vetorLinha[0]);
                y1 = int.Parse(vetorLinha[1]);
                x2 = int.Parse(vetorLinha[2]);
                y2 = int.Parse(vetorLinha[3]);

                calcx = x1 - x2;
                calcy = y1 - y2;
                if (calcx < 0)
                { 
                    calcx = calcx * -1;
                }
                if (calcy < 0)
                {
                    calcy = calcy * -1;
                }




                if (x1 == 0 && x2 == 0 && y1 == 0 && y2 == 0)
                {
                    break;
                }
                else if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("0");
                }
                else if (x1 == x2 || y1 == y2)
                {
                    Console.WriteLine("1");
                }
                else if (calcx == calcy)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
        }
    }
}
