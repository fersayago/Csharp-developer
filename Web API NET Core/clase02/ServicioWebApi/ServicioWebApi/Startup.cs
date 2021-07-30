using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServicioWebApi.Model;

namespace ServicioWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // registro la clase del contexto para trabajar con EF core in Memory
            services.AddDbContext<Contexto>
                (opciones => opciones.UseInMemoryDatabase("AmigosDB"));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,Contexto contexto)
        {
            if (!contexto.Amigo.Any())
            {
                Amigo a1 = new Amigo { ID = 1, Apellido = "Castro", Nombre = "Javier" };
                Amigo a2 = new Amigo { ID = 2, Apellido = "Gareca", Nombre = "Julian" };
                Amigo a3 = new Amigo { ID = 3, Apellido = "Mudry", Nombre = "Julian" };
                Amigo a4 = new Amigo { ID = 4, Apellido = "Bernatek", Nombre = "Joaquin" };

                contexto.Amigo.Add(a1);
                contexto.Amigo.Add(a2);
                contexto.Amigo.Add(a3);
                contexto.Amigo.Add(a4);

                //guardo en la bbdd
                contexto.SaveChanges();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
