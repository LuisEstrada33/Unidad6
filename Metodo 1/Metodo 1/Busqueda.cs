using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_1
{
    class Busqueda
    {
         private int[] vector; //Se crea el vetor donde se guardaran los datos

        public void Cargar() //Metodo en el que se hara un ciclo para llenar el arreglo
        {
            Console.WriteLine("Busqueda Binaria");
            Console.WriteLine("Ingrese 10 Elementos");
            string linea;
            vector = new int[10];//Tamaño del  arreglo
            for (int f = 0; f < vector.Length; f++) //Ciclo para ingrear los valores al arreglo
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void busqueda(int num) //Metodo de busqueda en el arreglo para buscar el valor deseado
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;

            while (l <= h && found == false) // Ciclo para ir comparando los valores del arreglo con el valor deseado
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
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); } //Se imprime el mensaje si no se encuentra el dato
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }

        public void Imprimir() //Metod para impirmir el arreglo
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }


 
    }
}
