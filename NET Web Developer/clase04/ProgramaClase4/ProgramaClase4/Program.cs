using System;
using System.Collections.Generic;

namespace ProgramaClase4
{
    class Program
    {
        static void Main(string[] args)
        {

            // PRACTICA DE ARRAYS Y LISTAS

            // ARRAY
            /*
            string[] marcas = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Las marcas del array son: ");
            for (int i = 0; i < marcas.Length; i++)
            {
                Console.WriteLine(marcas[i]);
            }
            */

            // LISTA
            // mas opciones y mas flexible
            List<string> listMarcas = new List<string>();
            listMarcas.Add("Volvo");
            listMarcas.Add("BMW");
            listMarcas.Add("Ford");
            listMarcas.Add("Mazda");

            for (int i = 0; i < listMarcas.Count; i++)
            {
                string marca = listMarcas[i];
                Console.WriteLine(marca);
            }

            // ! retomar 44:00

            List<int> listNumeros = new List<int>();

            listNumeros.Add(3);
            listNumeros.Add(20);
            listNumeros.Add(1);
            listNumeros.Add(12);
            listNumeros.Add(9);
            //para agregar en una posicion exacta
            listNumeros.Insert(int 0, int 3);

            // sorting de listas
            listNumeros.Sort();

            Console.WriteLine("Los numeros en la lista luego de ordenarlos son: ");
            for (int i = 0; i < listNumeros.Count; i++)
            {
                Console.WriteLine(listNumeros[i]);
            }
        }
    }
}
