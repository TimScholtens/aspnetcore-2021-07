using DemoProject.DataAccess;
using DemoProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
	public class PenaltyController : Controller
	{
		private SoccerContext context;
		public PenaltyController(SoccerContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			// view components

			// action results: view, json, file, redirect
			// web api: no content ok 
			return View(context.Penalties.ToList());
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(PenaltyModel newPenalty) // model binding
		{
			if (!ModelState.IsValid)
			{
				Thread.Sleep(2000);
				return View();
			}

			//context.Database.
			context.Penalties.Add(newPenalty); // SQL injection is een stuk lastiger zo
			context.SaveChanges();
			return RedirectToAction("Index");
			//return Content($"{formData["nameq"]} schoot met {formData["speed"]}km/h");
		}
	}
}
