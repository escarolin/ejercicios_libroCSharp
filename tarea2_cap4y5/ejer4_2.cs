
using System;

namespace tarea2_cap4y5
{
    class ejero4_2
    {
        public static void elevar()
        {
            int num = 0, potencia = 0, resultado = 1;

            Console.WriteLine("Inserte el numero a elevar");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte la potenica");
            potencia = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < potencia; i++)
            {
                resultado = resultado * num;
            }
            Console.WriteLine("{0} ", resultado);
        }
    }
}