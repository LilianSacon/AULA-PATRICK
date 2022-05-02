using System;

namespace Beecrowd_Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            int.TryParse(Console.ReadLine(), out C);
            int.TryParse(Console.ReadLine(), out D);
            {
                Console.WriteLine("DIFERENCA = {0}", (A * B - C * D));
            }

        }
    }
}
