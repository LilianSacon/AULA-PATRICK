using System;

namespace Orientacaoaobjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa Um
            string nomePessoaUm = Console.ReadLine();
            string sobrenomePessoaUm = Console.ReadLine();
            int idadePessoaUm = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nomePessoaUm} {sobrenomePessoaUm}");
            
            if (idadePessoaUm >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");
            
            //Pessoa Dois
            string nomePessoaDois = Console.ReadLine();
            string sobrenomePessoaDois = Console.ReadLine();
            long idadePessoaDois = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nomePessoaDois}-{sobrenomePessoaDois}");

            if (idadePessoaUm > 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");

            //Pessoa Três
            string nomePessoaTres = Console.ReadLine();
            string sobrenomePessoaTres = Console.ReadLine();

            Console.WriteLine($"{sobrenomePessoaTres} {nomePessoaTres}");

            Pessoa pessoaQuatro = new Pessoa();  //inicializa o objeto

            pessoaQuatro.nome = Console.ReadLine();
            pessoaQuatro.sobrenome = Console.ReadLine();
            pessoaQuatro.idade = int.Parse(Console.ReadLine());

            pessoaQuatro.ExibirNomeCompleto();

            Pessoa pessoaCinco = new Pessoa();

            pessoaCinco.nome = Console.ReadLine();
            pessoaCinco.sobrenome = Console.ReadLine();
            
            pessoaCinco.ExibirNomeCompleto();

            Console.ReadKey();
        }

        static int ObterNumero()
        {
            return 2;
        }
    }
}
