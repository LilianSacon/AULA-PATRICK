using System;

namespace Beecrowd_SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMBER;
            int HORAS;
            double VALOR;
            double SALARY;
            int.TryParse(Console.ReadLine(), out NUMBER);
            int.TryParse(Console.ReadLine(), out HORAS);
            double.TryParse(Console.ReadLine(), out VALOR);

            Console.WriteLine("NUMBER = {0}", NUMBER);
            SALARY = (VALOR * HORAS);
            Console.WriteLine("SALARY = U$ {0}", SALARY.ToString("F2"));
                     
            
        }
    }
}
