using System;

namespace Constante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double prova1 = 30;
            const double prova2 = 50;
            const double prova3 = 20;
            double nota1;
            double nota2;
            double nota3;

            Console.WriteLine("Digite a Nota da Prova 1:");
            Double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Digite a Nota da Prova 2:");
            Double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("Digite a Nota da Prova 3:");
            Double.TryParse(Console.ReadLine(), out nota3);

            double media = ((nota1 * prova1) + (nota2 * prova2) + (nota3 * prova3)) / 100;
            Console.WriteLine("Sua media e");
            Console.WriteLine(media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabéns");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Recuperação");
            }
        }
    }
}
