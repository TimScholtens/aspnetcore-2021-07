using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class PenaltyModel
    {
		public int Id { get; set; }

		public string Name { get; set; }

		public decimal Speed { get; set; } // kilometers per hour

		public bool Scored { get; set; }

		public string PhotoFace { get; set; }
	}
}
