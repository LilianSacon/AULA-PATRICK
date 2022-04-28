using System;

namespace MinhasInformacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            int Idade;
            string Peso;

            Console.WriteLine("Digite o seu Nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a sua Idade:");
            int.TryParse(Console.ReadLine(), out Idade);

            Console.WriteLine("Digite o seu Peso:");
            Peso = Console.ReadLine();

            Console.WriteLine("Seu nome é:");
            Console.WriteLine(Nome);

            Console.WriteLine("Sua idade é:");
            Console.WriteLine(Idade);

            Console.WriteLine("Seu peso é:");
            Console.WriteLine(Peso);    
               


        }
    }
}
