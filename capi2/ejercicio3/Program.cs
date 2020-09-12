using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           double grados, radianes;
            double Pi = 3.1416;
            string valor = "";
           Console.Write("Grados a convertir:");
            valor = Console.ReadLine();
            grados = Convert.ToDouble(valor);
            radianes = gradosRadianes(grados, Pi);
            Console.WriteLine("{0}°equivale a (1) radianes",grados,radianes);

        }
        static double gradosRadianes(double v1,double v2)
        {
            double r = 0.0;
            r = (v1 * v2) / 180;

           
            return r;
        }
    }
}
