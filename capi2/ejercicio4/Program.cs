using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          
          float g = 0, R= 0;
            string v = "";
 
            Console.Write("Dijite los grado  a Convertir");
            v = Console.ReadLine();
            g= Convert.ToSingle(v);
 
            R = (g* 9 / 5) + 32;
            Console.WriteLine(" Fahrenheit Es: {0}", R);
        }
    }
}
