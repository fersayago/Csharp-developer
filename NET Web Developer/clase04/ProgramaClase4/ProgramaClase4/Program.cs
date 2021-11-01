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

            //for y foreach

            for (int i = 0; i < listMarcas.Count; i++)
            {
                string marca = listMarcas[i];
                Console.WriteLine(marca);
            }

            Console.WriteLine("La marca con foreach es:");
            foreach (var item in listMarcas)
            {
                Console.WriteLine(item);
            }

            List<int> listNumeros = new List<int>();

            listNumeros.Add(3);
            listNumeros.Add(20);
            listNumeros.Add(1);
            listNumeros.Add(12);
            listNumeros.Add(9);
            //para agregar en una posicion exacta
            listNumeros.Insert(0, 3);

            // sorting de listas
            listNumeros.Sort();

            Console.WriteLine("Los numeros en la lista luego de ordenarlos son: ");
            //for (int i = 0; i < listNumeros.Count; i++)
            //{
            //    Console.WriteLine(listNumeros[i]);
            //}
            foreach (var item in listNumeros)
            {
                int nro = item;
                Console.WriteLine("El nro por foreach es: " + nro);
            }

            Console.WriteLine("----------------------------------------------");

            Auto objetoAuto = new Auto();

            // ! RETOMAR 56:52
        }
    }
}
