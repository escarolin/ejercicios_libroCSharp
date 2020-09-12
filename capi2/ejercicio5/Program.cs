using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float cambio = 0, dolar = 0, total = 0;
            string Canb= "";
            string dola= "";

            Console.Write("Ingrese el Cambio del Dia: ");
            Canb = Console.ReadLine();
            cambio = Convert.ToSingle(Canb);

            Console.Write("Ingrese la cantidad de Dolares: ");
            dola= Console.ReadLine();
            dolar = Convert.ToSingle(dola);

            total = cambio * dolar;

            Console.WriteLine(total + " Euros");
    }
}
}
