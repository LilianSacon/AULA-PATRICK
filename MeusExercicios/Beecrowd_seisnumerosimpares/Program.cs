using System;

namespace Beecrowd_seisnumerosimpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            int i;

            int.TryParse(Console.ReadLine(), out X);

            for (i = 1; i <= X; i = i++)
            {
                if (i % 6 != 0)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}