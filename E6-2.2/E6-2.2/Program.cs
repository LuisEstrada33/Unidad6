using E6_2._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusquedaBinaria
{
    class Busqueda
    {
        static void Main(string[] args)
        {
            Binaria pv = new E6_2._2.Binaria();
            pv.Cargar();
            pv.Imprimir();
            Console.Write("\n\nElemento a buscar: ");
            int num = int.Parse(Console.ReadLine());
            pv.busqueda(num);
            Console.ReadKey();


        }
    }
}
