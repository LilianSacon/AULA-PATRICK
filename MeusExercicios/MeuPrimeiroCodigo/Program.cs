﻿using System;

namespace MeuPrimeiroCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.WriteLine("Digite a Nota 1:");
            Double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Digite a Nota 2:");
            Double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("Digite a Nota 3:");
            Double.TryParse(Console.ReadLine(), out nota3);

            media = (nota1 + nota2 + nota3) / 3;
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
