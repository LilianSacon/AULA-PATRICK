using System;

namespace Beecrowd_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Entrada1;
            string Entrada2;
            string Entrada3;
            Console.WriteLine("");
            Entrada1 = Console.ReadLine();
            Console.WriteLine("");
            Entrada2 = Console.ReadLine();
            Console.WriteLine("");
            Entrada3 = Console.ReadLine();

            if (Entrada1 == ("vertebrado"))
            {
                if (Entrada2 == ("ave"))
                {
                    if (Entrada3 == ("carnivoro"))
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (Entrada3 == ("onivoro"))
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (Entrada2 == ("inseto"))
                {
                    if (Entrada3 == ("hematofago")) { Console.WriteLine("pulga"); }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (Entrada3 == ("hematofago")) { Console.WriteLine("sanguessuga"); }
                    else { Console.WriteLine("minhoca"); }
                }
            }
        }

                    
                    
                
            
        
    }
}
