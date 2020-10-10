using System;

namespace Tarea5_cap10y12
{
    class Ejer12_1
    {
        static void Main(string[] args)
        {
            int Numero;

            Console.Write("Ingrese un numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial de {0} es {1}", Numero, factorial(Numero));
        }

        public static int factorial(int Num)
        {
            int Resultado = 1;

            for (int i = Num; i > 1; i--)
            {
                Resultado *= i;
            }

            return Resultado;
        }
    }
}
