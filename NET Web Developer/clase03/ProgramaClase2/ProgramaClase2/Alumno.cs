using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaClase2
{
    public class Alumno
    {
        /* GETTERS Y SETTERS MANUALES
        
        /Atributos de la clase
        private string nombre;
        
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }
        */

        // para dar permisos de lectura sobre estos atributos privados tengo que dar un GET
        // para dar permisos de escritura sobre estos atributos privados tengo que dar un SET
        // los atributos publicos no necesitan getters ni setters

        // para hacer mas sencillos los getters y setters
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Cuota { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public bool CuotaAlDia { get; set; }

        // hacemos el constructor con la cantidad de objetos minimos para que tenga sentido

        // CONSTRUCTOR (recibe cantidad minima de atributos para que tenga sentido)
        public Alumno(string nombre, string apellido, string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }

        // SEGUNDO CONSTRUCTOR (overwritten)
        public Alumno(string nombre, string apellido, string documento,
            int legajo, DateTime fechaNacimiento, decimal cuota,
            string telefono, string mail)
        {
            // "this.Nombre = nombre;" === "Nombre = nombre;"
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.Legajo = legajo;
            this.FechaNacimiento = fechaNacimiento;
            this.Cuota = cuota;
            this.Telefono = telefono;
            this.Mail = mail;
            // definimos la fecha de alta como la fecha de creación del alumno
            this.FechaAlta = DateTime.Now;
            // damos por sentado que al crear el usuario tiene cuota al dia
            this.CuotaAlDia = true;
        }

        /* METODOS
         * 
         * Caracteristicas de un metodo:
         * Visibilidad                          public
         * Dato que devuelve                    string
         * Nombre                               MostrarDatos
         * Parametro que recibe <- opcional     ()
         */

        public string MostrarDatos()
        {
            string valorADevolver = Nombre + " " + Apellido + " " + Documento;
            return valorADevolver;
        }


        // Muestro por pantalla todos los datos creados en el nuevo metodo
        public string MostrarDatosExtendidos()
        {
            string valorADevolver = Nombre + " " + Apellido + " " + Documento;
            valorADevolver += "\nLegajo: " + Legajo + "\nFecha Nacimiento: " + FechaNacimiento.ToString();
            valorADevolver += "\nCuota: " + Cuota + "\nCuota al dia? " + CuotaAlDia;
            valorADevolver += "\nTelefono: " + Telefono + "\ncorreo: " + Mail;
            valorADevolver += "\nFecha de alta: " + FechaAlta.ToString();

            return valorADevolver;
        }


        public void AumentarCuota(decimal aumento)
        {
            this.Cuota += aumento;
        }

        public bool validarEdad(int edad)
        {
            // obtengo fecha de hoy
            DateTime fechaHoy = DateTime.Now;

            //restar el año de la fecha de hoy - el año de la fecha de nac
            int aniosEntreFechas = fechaHoy.Year - FechaNacimiento.Year;
            bool respuesta = false;
            if (edad == aniosEntreFechas)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
    }
}
