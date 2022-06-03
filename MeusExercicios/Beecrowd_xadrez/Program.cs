using System;

namespace Beecrowd_xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int c;

            int.TryParse(Console.ReadLine(), out l);
            int.TryParse(Console.ReadLine(), out c);

            if ((l + c) % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
