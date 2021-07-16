using DemoProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
	public class AuthController : Controller
	{
		private readonly UserManager<FanUserModel> userManager;
		private readonly SignInManager<FanUserModel> signInManager;
		public AuthController(UserManager<FanUserModel> userManager, SignInManager<FanUserModel> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		public IActionResult DoNothing()
		{

			return View("Auth");
		}

		public async Task<IActionResult> Register()
		{
			var result = await userManager.CreateAsync(new FanUserModel
			{
				UserName = "JP",
				Email = "jp@Jp.nl",
				FavorieteTeam = "Hogwarts"
			}, "top$ECRET15)(*");
			if (result.Succeeded)
			{
				ViewData["Status"] = "Geregistreerd!";
			}
			else
			{
				ViewData["Status"] = $"Kon niet registreren: {string.Join(", ", result.Errors.Select(x => x.Description))}";
			}
			return View("Auth");
		}

		public async Task<IActionResult> LogIn()
		{
			var result = await signInManager.PasswordSignInAsync("JP", "top$ECRET15)(*", true, false);
			if (result.Succeeded)
			{
				ViewData["Status"] = "Ingelogd!";
			}
			else
			{
				ViewData["Status"] = $"Kon niet inloggen: {result.IsLockedOut} | {result.IsNotAllowed} | {result.RequiresTwoFactor}";
			}
			return View("Auth");
		}

		public async Task<IActionResult> LogOut()
		{
			await signInManager.SignOutAsync();
			ViewData["Status"] = "Uitgelogd!";
			return View("Auth");
		}
	}
}
