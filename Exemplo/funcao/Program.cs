using System;

namespace funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            double valor = 0;
            bool conseguiconverter = false;
            string linhaDigitada = Console.ReadLine();
            conseguiconverter = double.TryParse(Console.ReadLine(), out valor);
            double.TryParse("", out );       //quando quer retornar mais de um tipo usa o out.


            double somaNumeros(int a, int b, double c )
            { int resultado = a + b; return resultado; }
        }
        var resultado3 = Math.Round(12.124, 2);
    }
}
//
//{ bool TryParse(string linha,out double valor)
//    {valor = 0 }


//Exemplo de função
//-----Aqui é a função---------
//int soma (string a, int b)

//{ int resultado = a + b;
//if (variavelglobal == 6)
//  {
//    return 9999; 
//}
//variavelglobal = resultado;
//return resultado;
//}


