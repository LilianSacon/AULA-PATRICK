using System;

namespace Beecrowd_Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y;
            double consumo;
           
            int.TryParse(Console.ReadLine(), out X);
            double.TryParse(Console.ReadLine(), out Y);

            consumo = (X / Y);
            Console.WriteLine(consumo.ToString("F3") + " km/l");


        }
    }
}
