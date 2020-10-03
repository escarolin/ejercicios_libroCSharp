using System;



namespace Tarea4_cap8y9
{
    class Ejer8_3
    {
        static void Main(string[] args)
        {
            String formato;

            formato = String.Format("La fecha es: {0:HH:mmtt yyyy dd MMM }", DateTime.Now);
            Console.WriteLine(formato);
        }
    }
}