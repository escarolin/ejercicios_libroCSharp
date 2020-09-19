using System;

namespace tarea2_cap4y5
{
     public class Ejer4_1
    {
       

        public static void tabla()
        {
            int num;
            Console.WriteLine("digite un numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + i * num);
            }

        }

    }

}
