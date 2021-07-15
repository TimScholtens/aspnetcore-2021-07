using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class ActorModel
    {
		public string Name { get; set; }

		public List<MovieModel> Movies { get; set; }
	}
}
