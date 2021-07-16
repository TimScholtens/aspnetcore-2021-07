using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
		{
            return View();
		}
    }
}
