using System;

namespace Beecrowd_Led
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;
            int j;
            int led = 0;
            string linha;
            
           
            int.TryParse(Console.ReadLine(), out N);

            for (i = 0; i < N; i++)
            {
                linha = Console.ReadLine();
                led = 0;
                
                for (j = 0; j < linha.Length; j++)
                {

                    if (linha[j] == '1')
                    {
                        led = led + 2;
                    }
                    else if (linha[j] == '2')
                    {
                        led = led + 5;
                    }
                    else if (linha[j] == '3')
                    {
                        led = led + 5;
                    }
                    else if (linha[j] == '4')
                    {
                        led = led + 4;
                    }
                    else if (linha[j] == '5')
                    {
                        led = led + 5;
                    }
                    else if (linha[j] == '6')
                    {
                        led = led + 6;
                    }
                    else if (linha[j] == '7')
                    {
                        led = led + 3;
                    }
                    else if (linha[j] == '8')
                    {
                        led = led + 7;
                    }
                    else if (linha[j] == '9')
                    {
                        led = led + 6;
                    }
                    else if (linha[j] == '0')
                    {
                        led = led + 6;
                    }
                }
                Console.WriteLine(led + " leds");

            }
        }
    }
}
