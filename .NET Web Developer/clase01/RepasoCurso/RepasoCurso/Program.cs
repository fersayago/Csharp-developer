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

            // CONVERTIR DATOS

            string cadenaAConvertir = "123456";

            int numeroConvertido = Convert.ToInt32(cadenaAConvertir);

            Console.WriteLine("Convertimos la cadena " + cadenaAConvertir + " a numero " + numeroConvertido);

            // ESTRUCTURAS DE DECISION

            // if if/else

            int h = 99;

            if (h <= 100)
            {
                // codigo cuando la condicion se cumple
                Console.WriteLine("La condicion se cumple, entro en el if");
            } else
            {
                Console.WriteLine("La condicion no se cumple, salgo por el else");
            }

            // ciclos while

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Soy un texto que se repite por " + (contador + 1) + "° vez en ciclo WHILE");
                // contador = contador + 1;
                contador++;
            }

            // ciclos for

            for (int cont = 0; cont < 5; cont++)
            {
                Console.WriteLine("Soy un texto que se repite por " + (cont + 1) + "° vez en ciclo FOR");
            }

            // switch

            int k = 15;
            
            switch (k)
            {
                case 10:
                    Console.WriteLine("k es igual a 10");
                    break;
                case 20:
                    Console.WriteLine("k es igual a 20");
                    break;
                default:
                    Console.WriteLine("k no es ni 10 ni 20");
                    break;
            } 

            Console.ReadKey(); // Para que no se cierre la consola
        }
    }
}
