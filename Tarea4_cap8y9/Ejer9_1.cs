using System;
using System.Text;

namespace Tarea4_cap8y9
{
    class Ejer9_1
    {
        public struct Producto
        {
            public float Precio;
            public String Nombre;
            public int Cantidad;

            public Producto(float Precio1, String Nombre1, int Cantidad1)
            {
                Precio = Precio1;
                Nombre = Nombre1;
                Cantidad = Cantidad1;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre del Producto: {0}, Cantidad del Producto: {1}, Precio del Producto: {2}", Nombre, Cantidad, Precio);
                return sb.ToString();
            }
        }


        static void Main(string[] args)
        {
            Producto Tienda;
            float Precio;
            int Cantidad;
            String Nombre;

            Console.WriteLine("Introduzca el Nombre del Producto:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el Precio del Producto:");
            Precio = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduzca la Cantidad del Producto:");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Tienda = new Producto(Precio, Nombre, Cantidad);

            Console.WriteLine(Tienda.ToString());
        }
    }
}