﻿using System;

namespace ProgramaClase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de clases!");


            // crear un objeto alumno a partir de la clase alumno


            // PRIMER ALUMNO
            // creamos un objeto a partir de la clase Alumno
            // en el primer alumno definimos que vamos a crear y en el segundo estoy llamando al constructor
            Alumno objetoAlumno1 = new Alumno("Juan", "Morales", "123456");

            // agregamos un elemento luego de construir el objeto
            objetoAlumno1.Mail = "jmorales@gmail.com";
            objetoAlumno1.Telefono = "42913738";
            objetoAlumno1.FechaNacimiento = new DateTime(1980,9,25);
            objetoAlumno1.Cuota = 1500.50m;
            objetoAlumno1.CuotaAlDia = true;
            objetoAlumno1.FechaAlta = DateTime.Now;

            // creamos un string invocando al metodo de la clase Alumno
            // (devuelve nombre, apellido y legajo)
            string datosAlumno1 = objetoAlumno1.MostrarDatos();


            Console.WriteLine("----------DATOS DEL PRIMER ALUMNO----------");
            Console.WriteLine("El nombre del alumno generado es: " + objetoAlumno1.Nombre + " " + objetoAlumno1.Apellido);
            Console.WriteLine("El mail del alumno es: " + objetoAlumno1.Mail);
            Console.WriteLine("La fecha de nacimiento del alumno es: " + objetoAlumno1.FechaNacimiento);
            Console.WriteLine("\n RESUMEN DEL ALUMNO MEDIANTE METODO:\n" + datosAlumno1);


            // SEGUNDO ALUMNO
            Alumno objetoAlumno2 = new Alumno("Fernando", "Sayago", "123678");
            objetoAlumno2.Mail = "fsayago@andreani.com";
            objetoAlumno2.Telefono = "42913532";
            objetoAlumno2.FechaNacimiento = new DateTime(1992, 12, 18);

            string datosAlumno2 = objetoAlumno2.MostrarDatos();

            Console.WriteLine("----------DATOS DEL SEGUNDO ALUMNO----------");
            Console.WriteLine("El nombre del segundo alumno es: " + objetoAlumno2.Nombre + " " + objetoAlumno2.Apellido);
            Console.WriteLine("El mail del segundo alumno es: " + objetoAlumno2.Mail);
            Console.WriteLine("La fecha de nacimiento del segundo alumno es: " + objetoAlumno2.FechaNacimiento);
            Console.WriteLine("\nRESUMEN DEL ALUMNO MEDIANTE METODO:\n" + datosAlumno2);

            // TERCER ALUMNO
            Alumno objetoAlumno3 = new Alumno("Johnson", "The Third", "3924244",
                245876, new DateTime(1996, 10, 5), 2500, "1153-1245", "Jonhson@theThird.com");

            string datosAlumno3 = objetoAlumno3.MostrarDatosExtendidos();

            Console.WriteLine("----------DATOS DEL TERCER ALUMNO----------");
            Console.WriteLine("RESUMEN DEL ALUMNO MEDIANTE METODO:\n" + datosAlumno3);
            Console.WriteLine("----------FIN DATOS TERCER ALUMNO----------");


            // instancio profesor
            Profesor objetoProfesor1 = new Profesor("Lautaro", "Hernandez", "45698125");
            objetoProfesor1.Sueldo = 1500m;


            // ! RETOMAR 1:04:20
            

            Console.ReadKey();
                        
        }
    }
}