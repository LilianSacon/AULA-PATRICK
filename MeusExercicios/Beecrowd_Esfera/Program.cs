using System;

namespace Beecrowd_Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double raio;
            double area;
            double.TryParse(Console.ReadLine(), out raio);

            area = (4/3.0)*PI*Math.Pow(raio, 3);
            Console.WriteLine("VOLUME =" + area.ToString("F3"));
            
        }
    }
}
