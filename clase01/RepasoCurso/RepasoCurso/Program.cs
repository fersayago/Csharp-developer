using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PRUEBA EN C#:");

            // TIPOS DE VARIABLE

            // entera
            int numeroEntero = 123;
            Console.WriteLine("Mi variable entera es " + numeroEntero);

            // acá faltan short, long y otros

            // variables decimales Double, Float decimal
            double dobleDigitos = 12.34;
            Console.WriteLine("Mi variable double es " + dobleDigitos);
            decimal numeroDecimal = 12.642m;
            Console.WriteLine("Mi variable decimal es " + numeroDecimal);

            // variable booleano
            bool tengoSueño = true;
            Console.WriteLine("Mi variable bool es" + tengoSueño);
            
            // variable de texto
            string cadena = "Hola Mundo";
            Console.WriteLine(cadena);

            //variable fecha: date, DateTime
            DateTime fechaHoy = DateTime.Now;
            Console.WriteLine("Mi variable fecha es:" + fechaHoy);

            // Cast de variables

            // pasar de una variable string a una int
            string cadenaNumero = "1500";

            int dobleDeCadena = int.Parse(cadenaNumero) * 2;

            Console.WriteLine("El doble de " + cadenaNumero + " es " + dobleDeCadena);

            // ! Retomar 1:24:00


            Console.ReadKey(); // Para que no se cierre la consola
        }
    }
}
