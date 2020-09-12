using System;

namespace capi2
{
    class Program
    {
        static void Main(String[] args)
        {
           double cantidad,lado,Perimetro;

         Console.Write ("Lado:");
         lado=double.Parse(Console.ReadLine());
         Console.Write ("cantidad:");
         cantidad=double.Parse(Console.ReadLine());
         Perimetro=lado*cantidad;
         Console.WriteLine("Perimetro={0}",Perimetro);
         Console.ReadKey();
            
            
        }
    }
}
