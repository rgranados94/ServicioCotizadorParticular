using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizadorParticular.Aplicacion.Contrato.Servicio;
using CotizadorParticular.Aplicacion.Servicio.Servicio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using CotizadorParticular.Infraestructura.AutoMapper;
using CotizadorParticular.Dominio.Entidad;
using CotizadorParticular.Nucleo.DTO.RequestDTO;

namespace CotizadorParticular.API
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
            services.AddControllers();
            services.AddScoped<IOperationService, OperationService>();
            //services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(typeof(MapperInstance));
            //services.AddTransient<MyService, MyService>();
            services.AddSingleton<MyService, MyService>();
            services.AddSingleton<ConsultarClienteRequest, ConsultarClienteRequest>();
            //services.AddSingleton(Isingelton)
            //services.AddLogging(ILogger);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
