using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5_cap10y12
{
    class Estudiantes_Ejer10_2
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int OrdenLista { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }

        public Estudiantes_Ejer10_2()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            OrdenLista = 0;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
        }
    }
}