using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashing Hash = new Hashing(8);
            string[] Elementos = { "22", "95", "75", "80", "77", "90", "33", "45" };
            Hash.FuncionHash(Elementos,Hash.array);
            Hash.Mostrar();
            string Buscar = Hash.BuscarClave("1");
            if(Buscar==null)
            {
                Console.WriteLine("El elemento " + Buscar + " no se encuentra");
            }
            Console.ReadKey();
        }
    }
}
