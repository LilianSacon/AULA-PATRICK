﻿using System;

namespace Beecrowd_SomaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int resultado;
            Int32.TryParse(Console.ReadLine(), out A);
            Int32.TryParse(Console.ReadLine(), out B);

            resultado = A + B;
            Console.WriteLine("SOMA = " + resultado);
        }
    }
}
