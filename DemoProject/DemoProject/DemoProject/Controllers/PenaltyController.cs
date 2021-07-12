using DemoProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{

	public class PenaltyController : Controller
	{
		private static List<PenaltyModel> penalties = new List<PenaltyModel>
			{
				new PenaltyModel
				{
					Id = 4,
					Name = "Marcus Rashford",
					Scored = false,
					Speed = 125.4M,
					PhotoFace = "https://static.timesofisrael.com/www/uploads/2021/07/AP21192809451607.jpg"
				},
				new PenaltyModel
				{
					Id = 8,
					Name = "Jadon Sancho",
					Scored = false,
					Speed = 119.9M,
					PhotoFace = "https://e0.365dm.com/21/07/768x432/skysports-jadon-sancho-miss_5444467.jpg?20210711230603"
				},
				new PenaltyModel
				{
					Id = 15,
					Name = "Bukayo Saka",
					Scored = false,
					Speed = 12.8M,
					PhotoFace = "https://i2-prod.football.london/incoming/article21028279.ece/ALTERNATES/s1200c/0_Saka.jpg"
				}
			};


		public IActionResult Index()
		{
			// view components

			// action results: view, json, file, redirect
			// web api: no content ok 
			return View(penalties);
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
				return View();
			}

			penalties.Add(newPenalty);
			return RedirectToAction("Index");
			//return Content($"{formData["nameq"]} schoot met {formData["speed"]}km/h");
		}
	}
}
