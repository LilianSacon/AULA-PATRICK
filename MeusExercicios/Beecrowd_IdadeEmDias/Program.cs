using System;

namespace Beecrowd_IdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int.TryParse(Console.ReadLine(), out idade);

            int ano = (int)Math.Truncate(idade / 365.0);
            idade = idade - (ano * 365);
            Console.WriteLine(ano + " ano(s)");

            int meses = (int)Math.Truncate(idade / 30.0);
            idade = idade - (meses * 30);
            Console.WriteLine(meses + " mes(es)");

            int dias = (int) idade;
            idade = idade - dias;
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
