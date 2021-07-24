using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ejemplo1.Models;

namespace Ejemplo1.Controllers
{
    public class ShippersController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        // metodos de accion
        [HttpGet] public List<Shipper> TraerTodos()
        {
            //con el lenguaje LINQ accedo a recuperar informacion de los Shippers
            var listaShippers = (from sh in db.Shippers
                                select sh).ToList();
            return listaShippers;

            // ! RETOMAR 1:58:30

        }
    }
}
