<<<<<<< HEAD
﻿using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            float dia = 0;
            string di = "";

            Console.Write("Dijite un numero del 1 al 7: ");
            di= Console.ReadLine();
            dia = Convert.ToSingle(di);

            if(dia == 1)
            {
                Console.Write("Lunes.\n");
            }
            else if (dia == 2)
            {
                Console.Write("Martes.\n");
            }
            else if(dia == 3)
            {
                Console.Write("Miercoles.\n");
            }
            else if(dia == 4)
            {
                Console.Write("Jueves.\n");
            }
            else if(dia == 5)
            {
                Console.Write("Viernes.\n");
            }
            else if(dia == 6)
            {
                Console.Write("Sabado.\n");
            }
            else if(dia == 7)
            {
                Console.Write("Domingo.\n");
            }
            
            else if(dia <= 0)
            {
                Console.Write("\n incorrecto  dijite un numero entre 1 y el 7  ingreso el " + di + ".\n");
            }
        }
    }
}

=======
﻿using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            float dia = 0;
            string di = "";

            Console.Write("Dijite un numero del 1 al 7: ");
            di= Console.ReadLine();
            dia = Convert.ToSingle(di);

            if(dia == 1)
            {
                Console.Write("Lunes.\n");
            }
            else if (dia == 2)
            {
                Console.Write("Martes.\n");
            }
            else if(dia == 3)
            {
                Console.Write("Miercoles.\n");
            }
            else if(dia == 4)
            {
                Console.Write("Jueves.\n");
            }
            else if(dia == 5)
            {
                Console.Write("Viernes.\n");
            }
            else if(dia == 6)
            {
                Console.Write("Sabado.\n");
            }
            else if(dia == 7)
            {
                Console.Write("Domingo.\n");
            }
            
            else if(dia <= 0)
            {
                Console.Write("\n incorrecto  dijite un numero entre 1 y el 7  ingreso el " + di + ".\n");
            }
        }
    }
}
>>>>>>> f57685fa5d561d181bd1db69631bda8267747794
