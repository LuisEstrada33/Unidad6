using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    public class Hashing
    {
        public string[] array;
        int Tamaño;

        public Hashing(int tam)
        {
            Tamaño = tam;
            array = new string[tam];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = "-1";
            }
        }
        public void FuncionHash(string[] CadenaArray, string[] Arreglo)
        {
            for (int i = 0; i < CadenaArray.Length; i++)
            {
                string Elemento = CadenaArray[i];
                int IndiceArray = int.Parse(Elemento) % 7;
                Console.WriteLine("El indice es: " + IndiceArray + " Para el elemento" + Elemento);
                while (array[IndiceArray] != "-1")
                {
                    IndiceArray++;
                    Console.WriteLine("Error en el indice: " + (IndiceArray - 1) + " cambiar al indice: " + IndiceArray);
                    IndiceArray %= Tamaño;
                }
                array[IndiceArray] = Elemento;
            }
        }
        public void Mostrar()
        {
            int Incremento = 0, j;
            for (int i = 0; i < 1; i++)
            {
                Incremento += 8;
                for ( j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = Incremento; j < Incremento; j++)
                {
                    Console.Write(string.Format("|  {0}" + " ", j));
                }
                Console.WriteLine("|");
                for (int n = 0; n < 71; n++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = Incremento-8; j <Incremento; j++)
                {
                    if(array[j].Equals("-1"))
                    {
                        Console.Write("|  ");
                        
                    }
                    else
                    {
                        Console.Write(String.Format("| {0}" + " ", array[j]));
                    }
                }
                Console.WriteLine(" | ");
                for ( j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
         }
        public string BuscarClave(string Elemento)
        {
            int IndiceArray = int.Parse(Elemento) % 7;
            int Contador = 0;
            while (array[IndiceArray]!="-1")
            {
                if(array[IndiceArray]==Elemento)
                {
                    Console.WriteLine("El elemento " + Elemento + " fue encontrado en el indice" + IndiceArray);
                    return array[IndiceArray];
                }
                IndiceArray++;
                IndiceArray %= Tamaño;
                Contador++;
                if(Contador>7)
                {
                    break;
                }
            }
            return null;
        }
    } 
}

            
        
    

