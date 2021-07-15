using DemoProject.DataAccess;
using DemoProject.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			// dependency injection / globale instellingen
			services.AddDbContext<SoccerContext>(options =>
			{
				options.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog=soccerdb; Integrated Security=true;");
			}, ServiceLifetime.Transient);

			services.AddTransient<IPenaltyRepository, PenaltyRepository>();
			services.AddTransient<IPlayerRepository, PlayerRepository>();
			services.AddControllersWithViews().AddNewtonsoftJson(options =>
			{
				//options.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

				//options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver

				// datum en tijd

				// this is not default JSON
				// JSON.parse()
				// $id: 6
				// $ref: 6
			});
			//	.AddJsonOptions(options =>
			//{
			//	options.JsonSerializerOptions
			//}); // MVC

			services.AddCors();

			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo { Title = "Mijn APIs", Version = "v1" });
			});

			services.AddMemoryCache();

			services.AddSession();

			//services.AddDistributedMemoryCache()

			//services.AddRedis
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// voor iedere request
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();

				app.UseSwagger();

				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mijn APIs v1"));
			}

			app.UseCors(options =>
			{
				// wees iets specifieker in productie
				options.WithOrigins("https://localhost:44375").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
			});

			app.UseSession(); // leest de sesion cookie uit

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				// default route

				//endpoints.MapControllerRoute("specifiek", "Iets/Bla", new { controller = "Iestsje", action = "sdklfjdslk" });

				endpoints.MapControllerRoute("Default", "{controller}/{action}/{id?}");
				endpoints.MapControllers();
			});
		}
	}
}

