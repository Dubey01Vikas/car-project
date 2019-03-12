using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models;
using CarPlace_Backend.Models.DataController;
using CarPlace_Backend.Models.Repository;

namespace CarPlace_Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) { 


             services.AddDbContext<ZoomCarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<CarDetailsInterface<CarDetails>, CarDetailsMgmt>();
            services.AddScoped<Repository<OrderDetails>, OrderDbMgmt>();
            services.AddScoped<IUser<ZoomCarUser>, ZoomCarUserDbMgmt>();
            services.AddCors(options => options.AddPolicy("Cors", builder =>{
               builder.AllowAnyOrigin()
              .AllowAnyMethod()
               .AllowAnyHeader();
                    }));

                 services.AddMvc();
          
            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        app.UseCors("Cors");
         app.UseMvc();
        }
    }
}
