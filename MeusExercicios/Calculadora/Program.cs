using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolver uma calculadora
             * que vai ler um numero
             * depois vai ler o segundo numero
             * depois vai ler o operador
             * como resposta o programa vai
             * responder o resultado da
             * operacao
             */

            double numero1;
            double numero2;
            string operador;

            // ler o primeiro numero
            Console.WriteLine("Digite o Numero 1:");
            double.TryParse(Console.ReadLine(), out numero1);
            // ler o segundo numero
            Console.WriteLine("Digite o Numero 2:");
            double.TryParse(Console.ReadLine(), out numero2);
            // ler o operador
            Console.WriteLine("Digite o operador (+, -, *, /):");
            operador = Console.ReadLine();
            // verificar o tipo do operador
            // realizar a operacao conforme o tipo verificado
            // imprimir o resultado
            if (operador == "+")
            {
                Console.WriteLine("Soma = {0}", numero1 + numero2);
            }
            else if (operador == "-")
            {
                Console.WriteLine("Subtração = {0}", numero1 - numero2);
            }
            else if (operador == "*")
            {
                Console.WriteLine("Multiplicação = {0}", numero1 * numero2);
            }
            else if (operador == "/" && numero2 == 0)
            {
                Console.WriteLine("Não foi possível executar o calculo");
            }
            else if (operador == "/")
                                
                Console.WriteLine("Divisão = {0}", numero1 / numero2);
            
            else if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                Console.WriteLine("Operador incorreto");
            }








        }
    }
}
