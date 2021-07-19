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
        public string Documento { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Cuota { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public bool CuotaAlDia { get; set; }

        // hacemos el constructor con la cantidad de objetos minimos para que tenga sentido

        // CONSTRUCTOR
        public Alumno(string nombre, string apellido, string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }

        // METODOS
        /* Caracteristicas de un metodo:
         * Visibilidad
         * Dato que devuelve
         * Nombre
         * Parametro que recibe <- opcional
         */

        public string MostrarDatos()
        {
            string valorADevolver = Nombre + " " + Apellido + " " + Documento;
            return valorADevolver;
        }


    }
}
