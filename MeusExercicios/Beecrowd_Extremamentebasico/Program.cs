using System;

namespace Beecrowd_Extremamentebasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int resultado;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);

            resultado = a + b;
            Console.WriteLine("X = " + resultado);





        }
    }
}
