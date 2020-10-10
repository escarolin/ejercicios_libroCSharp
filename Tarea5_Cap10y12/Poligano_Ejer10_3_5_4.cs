using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5_cap10y12
{
    class Poligano_Ejer10_3_5_4
    {
        private int Lados;
        private int Distancia;

        public int lados
        {
            get{ return Lados;}
            set{
                if (value >= 3)
                    Lados = value;
                else
                    Lados = 0;
            }
        }

        public int distancia
        {
            get{return Distancia;}
            set
            {
                if (value > 0)
                    Distancia = value;
                else
                    Distancia = 0;
            }
        }
        public Poligano_Ejer10_3_5_4()
        {
            Lados = 0;
            Distancia = 0;
        }

        public Poligano_Ejer10_3_5_4(int lados, int distancia)
        {
            Lados = lados;
            Distancia = distancia;
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Los lados del poligono son " + Lados.ToString() +
                        " y su distancia es " + Distancia.ToString();
            return mensaje;
        }


    }
}