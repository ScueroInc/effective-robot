using PC2.Repository.Context;
using PC2.Repository;
using PC2.Repository.Implementation;
using PC2.Service;
using PC2.Service.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace PC2.Api
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IPlantaRepository, PlantaRepository>();
            services.AddTransient<IPlantaService, PlantaService>();

            services.AddTransient<IViveroRepository, ViveroRepository>();
            services.AddTransient<IViveroService, ViveroService>();

            services.AddTransient<IPlanta_ViveroRepository, Planta_ViveroRepository>();
            services.AddTransient<IPlanta_ViveroService, Planta_ViveroService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            
            services.AddSwaggerGen (swagger => {
                var contact = new Contact () { Name = SwaggerConfiguration.ContactName, Url = SwaggerConfiguration.ContactUrl };
                swagger.SwaggerDoc (SwaggerConfiguration.DocNameV1,
                    new Info {
                        Title = SwaggerConfiguration.DocInfoTitle,
                            Version = SwaggerConfiguration.DocInfoVersion,
                            Description = SwaggerConfiguration.DocInfoDescription,
                            Contact = contact
                    }
                );
            });

            services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger ();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint (SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseCors ("Todos");
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
