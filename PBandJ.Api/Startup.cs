using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PBandJ.Api.Entities;
using PBandJ.Api.Repositories;
using PBandJ.Api.Repositories.Positions;
using PBandJ.Api.Repositories.Situations;
using PBandJ.Api.Services;
using PBandJ.Api.Services.HandRanges;
using PBandJ.Api.Services.Positions;
using PBandJ.Api.Services.Situations;

namespace PBandJ.Api
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO: Move to config
            string domain = $"https://handrangememorizer.auth0.com";
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.Authority = domain;
                options.Audience = "https://handrangememorizer.auth0.com/api/v2/";
            });

            services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod();;
                    });
            });

            //var connectionString = @"Data Source=tcp:s18.winhost.com;Initial Catalog=DB_118134_handrang;User ID=DB_118134_handrang_user;Password=J24hzkoPr2zpceReifju;Integrated Security=False;";
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=PBandJDb;Trusted_Connection=true";
            services.AddDbContext<HandRangeContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IHandRangeService, HandRangeService>();
            services.AddScoped<IHandRangeValidationService, HandRangeValidationService>();
            services.AddScoped<IHandRangeRepository, HandRangeRepository>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IScenarioService, ScenarioService>();
            services.AddScoped<IScenarioRepository, ScenarioRepository>();
            services.AddScoped<ISituationService, SituationService>();
            services.AddScoped<ISituationRepository, SituationRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
           
        }
    }
}
