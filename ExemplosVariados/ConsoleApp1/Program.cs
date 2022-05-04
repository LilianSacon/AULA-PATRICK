using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            int contador;
            
            //contador = 0;
            //numero1 = 0;
           

            for (contador = 0; contador <= 100; contador +=2)
                Console.WriteLine(contador);
            {
                if (contador % 2 == 0)
                {
                    numero1 = contador * 3;
                }
                else
                {
                    numero2 = contador + 9;
                }
            }
        }
    }
}
