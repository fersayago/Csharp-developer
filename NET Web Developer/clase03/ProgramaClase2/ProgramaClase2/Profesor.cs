using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaClase2
{
    class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Sueldo { get; set; }


        public Profesor(string nombre, string apellido, string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }

        public string MostrarDatos()
        {
            string valorADevolver = Nombre + " " + Apellido + " " + Documento;
            return valorADevolver;
        }
    }
}
