using System;

namespace Beecrowd_numerosimpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            int i;
            

            int.TryParse(Console.ReadLine(), out X);
            for (i = 1; i <= X; i++)
            
                
            { 
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                

            }
        }
    }
}
