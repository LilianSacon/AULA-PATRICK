using System;

namespace Beecrowd_SalarioComBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario;
            double vendas;

            nome = Console.ReadLine();
            double.TryParse(Console.ReadLine(), out salario);
            double.TryParse(Console.ReadLine(), out vendas);
            {
                Console.WriteLine("TOTAL = R$ {0}",(salario + (vendas * 15) / 100).ToString("F2"));
            }



        }
    }
}
