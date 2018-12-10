using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, puntero = 0, final = 11, mitad = -999;
            int[] vec = { 3, 5, 8, 10, 100, 11, 80, 3, 205, 7, 159, 36 };
            bool encontro = false;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while(!encontro && puntero<=final)
            {
                mitad = (int)((puntero + final) / 2);
                if (numero == vec[mitad])
                    encontro = true;

                else if (numero < vec[mitad])
                    final = mitad - 1;
                else
                    puntero = mitad + 1;                   
            }
            if (encontro)
                Console.Write("El dato se encuentra y esta en la posicion: " + (mitad + 1));
            else
                Console.Write("El dato no se encuentra");

            Console.ReadKey();
        }
    }
}
