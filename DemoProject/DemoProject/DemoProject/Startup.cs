using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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


			services.AddControllersWithViews(); // MVC

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			// voor iedere request

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				// default route
				endpoints.MapControllerRoute("Default", "{controller}/{action}/{id?}");
				//endpoints.MapControllers();
			});
		}
	}
}
