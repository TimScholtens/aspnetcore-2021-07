using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    public class StateController : Controller
    {
        IMemoryCache memCache;
        public StateController(IMemoryCache memCache)
		{
            this.memCache = memCache;
		}

        public string Nu()
		{
            // caching
            var nu = memCache.GetOrCreate("nu", entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(5));
                return DateTime.Now;
            });

            return nu.ToLongTimeString();
		}

        public string Session()
		{
            // werk.nl


            var nu = HttpContext.Session.Get<DateTime?>("nu");
            if(!nu.HasValue)
			{
                nu = DateTime.Now;
                HttpContext.Session.Set("nu", nu);
			}


            return nu.Value.ToLongTimeString();
		}
    }
}
