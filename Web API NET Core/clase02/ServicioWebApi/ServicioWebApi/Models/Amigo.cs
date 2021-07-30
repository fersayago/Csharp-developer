using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioWebApi.Model
{
    [Table("Amigos")] public class Amigo
    {
        [Key] public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}
