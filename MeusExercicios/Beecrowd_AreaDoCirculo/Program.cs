using System;

namespace Beecrowd_AreaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double n = 3.14159;
            double raio;
            double area;
            double.TryParse(Console.ReadLine(), out raio);

            area = (n * (raio * raio));
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
