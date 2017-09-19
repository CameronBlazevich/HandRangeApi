using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PBandJ.Api.Entities;
using PBandJ.Api.Services;

namespace PBandJ.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors();

            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=PBandJDb;Trusted_Connection=true";
            services.AddDbContext<HandRangeContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IHandRangeService, HandRangeService>();
            services.AddTransient<IHandRangeValidationService, HandRangeValidationService>();
            services.AddScoped<IHandRangeRepository, HandRangeRepository>();
            services.AddTransient<IPositionService, PositionService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder =>
                builder.WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
