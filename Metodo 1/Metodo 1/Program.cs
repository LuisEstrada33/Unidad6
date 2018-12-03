using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda pv = new Busqueda(); //Se crea el objeto
            pv.Cargar();// Se manda a llamar al metodo cargar
            pv.Imprimir();// se manda a llamar al metodo imprimir
            Console.Write("\n\nElemento a buscar: ");//Se pide el dato que se desea buscar
            int num = int.Parse(Console.ReadLine());
            pv.busqueda(num);// manda a llamar al metodo busqueda
            Console.ReadKey();
        }
    }
}
