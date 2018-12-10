using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_2._2
{
    class Binaria
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("Busqueda Binaria");
            Console.WriteLine("Ingrese 10 Elementos");
            string linea;
            vector = new int[10];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void busqueda(int num)
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;

            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }

        public void Imprimir()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }

    }
}
