using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5_cap10y12
{
    public class Tienda_Ejer10_1
    {
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public String NombreProducto { get; set; }

        public  Tienda_Ejer10_1()
        {
            Precio = 0;
            Unidades = 0;
            NombreProducto = string.Empty;
        }

        public Tienda_Ejer10_1(float pPrecio,int uUnidades,String nNombreProducto)
        {
            Precio = pPrecio;
            Unidades = uUnidades;
            NombreProducto = nNombreProducto;
        }
    }
}