using System;

namespace Beecrowd_Pum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int linha;
            int numero = 0;
            string PUM;
            
            
            int.TryParse(Console.ReadLine(), out N);

            for (linha = 1; linha <= N; linha++)
            {
                PUM = "";
                for (int i = 0; i < 3; i++)
                {
                    numero++;
                    if (PUM != "")
                        PUM = PUM + " ";

                    PUM = PUM + numero;
                }
                Console.WriteLine(PUM + " PUM");
                numero++;
            }
                           
        }
    }
}
