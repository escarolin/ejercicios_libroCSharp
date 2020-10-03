using System;
using System.Text;

namespace Tarea4_cap8y9
{
    class Ejer8_5
    {
        static void Main(string[] args)
        {
            String Cad1, Cad2;

            Console.WriteLine("Introduzca la primera cadena:");
            Cad1 = Console.ReadLine();

            Console.WriteLine("Introduzca la segunda cadena:");
            Cad2 = Console.ReadLine();

             Console.Clear();

            if (Cad1.CompareTo(Cad2) < 0)
            {
                Console.WriteLine("El orden es:\n{0}",Cad1);
                Console.WriteLine("{0}", Cad2);
            }
            else
            {
                Console.WriteLine("El orden es: \n{0}", Cad2);
                Console.WriteLine("{0}", Cad1);
                
            }
        }

      
    }
}