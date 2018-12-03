using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda Buscar = new Busqueda();

            List<int> Lista = new List<int>();
            
            Lista.Add(10);
            Lista.Add(6);
            Lista.Add(8);
            Lista.Add(15);
            Lista.Add(4);
            Lista.Add(20);
            Lista.Add(9);
            Lista.Add(30);
            Lista.Add(1);

            Console.Write("Que dato desea buscar?: " );
            int Elemento = int.Parse(Console.ReadLine());

            Console.WriteLine("BUSQUEDA SECUENCIAL");
            Console.WriteLine();
            Console.WriteLine("El elemento " + Elemento);
            Console.WriteLine("¿se encuentra en la lista? " + Buscar.BusquedaSecuencial(Elemento, Lista));
            Console.ReadKey();
        }
    }
}
