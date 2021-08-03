using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaClase2
{
    class Curso
    {
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public int CargaHorario { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public int DiasPorSemana { get; set; }
        public int Cupos { get; set; }
        public DateTime FechaInicio { get; set; }
        public Profesor ProfesorDelCurso { get; set; }
        public List<Alumno> AlumnosDelCurso { get; set; }

        public Curso (string nombre, string duracion, int cargaHoraria,
            string dia, string horario, DateTime fechaInicio)
        {
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.CargaHorario = cargaHoraria;
            this.Dia = dia;
            this.Horario = horario;
            this.FechaInicio = fechaInicio;

            // ! SIEMPRE QUE TRABAJO CON LISTAS LAS TENGO QUE INICIALIZAR
            AlumnosDelCurso = new List<Alumno>();
        }


        public string MostrarCurso()
        {
            string datosMostrar = $"Datos del curso: {Environment.NewLine}" +
                $"{Nombre} {Duracion} {Dia}";

            //agregamos los datos del profesor
            datosMostrar += $"\nDatos del profesor: {Environment.NewLine}" +
                $"{ProfesorDelCurso.MostrarDatos()}";
            return datosMostrar;
        }

    }
}
