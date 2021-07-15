using DemoProject.DataAccess;
using DemoProject.Models;
using DemoProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
		// repository pattern
		private IPenaltyRepository penalRepo;
		private IPlayerRepository playerRepo;
		public PenaltyController(IPenaltyRepository penalRepo, IPlayerRepository playerRepo)
		{
			this.penalRepo = penalRepo;
			this.playerRepo = playerRepo;
		}

		public async Task<IActionResult> Index()
		{
			// view components

			// action results: view, json, file, redirect
			// web api: no content ok 
			return View(await penalRepo.GetAllAsync());
		}

		[HttpGet]
		public async Task<IActionResult> Create()
		{
			//ViewData["DataMessage"] = "Hallo daar viewdata!"; // magic string
			//ViewBag.BagMessage = "Hallo daar viewbag!"; // magic property

			// unmanaged resources
			//dynamic bla = null;
			//bla.DoeIets(14, 28, "hoi", "haha", new { });
			ViewData["Players"] = (await playerRepo.GetAllAsync()).Select(x => new SelectListItem
			{
				Text = x.Name,
				Value = x.Id.ToString()
			});

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(PenaltyModel newPenalty) // model binding
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			//context.Database.
			await penalRepo.AddAsync(newPenalty);
			return RedirectToAction("Index");
			//return Content($"{formData["nameq"]} schoot met {formData["speed"]}km/h");
		}
	}
}
