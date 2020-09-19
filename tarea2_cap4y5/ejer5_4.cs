using System;

namespace tarea2_cap4y5
{

    class Ejercicio5_4
    {
        public static void factorial(int n)
        {
            int Factor = 1;
            for (int i = 1; i <= n; i++)
            {
                Factor = Factor * i;
            }
            Console.WriteLine(Factor);

        }
        public static void Factor()
        {
            int num = 0;
            Console.WriteLine("Dijite el numero ");
            num = Convert.ToInt32(Console.ReadLine());
            factorial(num);

        }

    }
}