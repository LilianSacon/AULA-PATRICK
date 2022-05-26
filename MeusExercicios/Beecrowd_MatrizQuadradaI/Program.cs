using System;

namespace Beecrowd_MatrizQuadradaI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
        {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                    break;
                else
                {
                    int x;
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            x = i;
                            if (j < x)
                                x = j;
                            if (n - i + 1 < x)
                                x = n - i + 1;
                            if (n - j + 1 < x)
                                x = n - j + 1;

                            if (x >= 10)
                                Console.Write(" {0}", x);
                            else
                            if (x >= 100)
                                Console.Write("{0}", x);
                            else
                                Console.Write("  {0}", x);

                            if (j < n)
                                Console.Write(" ");
                            else
                                Console.Write("\n");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
