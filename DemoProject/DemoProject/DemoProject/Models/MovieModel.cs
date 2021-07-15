using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class MovieModel
    {
		public string Title { get; set; }

		public DateTime ReleaseDate { get; set; }

		public List<ActorModel> Actors { get; set; }
	}
}
