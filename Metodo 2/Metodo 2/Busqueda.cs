using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_2
{
    class Busqueda
    {
        public bool BusquedaSecuencial(int Elemento, List<int> Lista)
        {
            int Tamaño = Lista.Count;
            int Posicion = 0;

            while (Posicion < Tamaño)
            {
                if (Lista[Posicion] == Elemento)
                {
                    return true;
                }
                else
                {
                    Posicion++;
                }
            }
            return false;
        }
    }
}
