using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class PenaltyModel
    {
		public int Id { get; set; }

		[Required]
		[RegularExpression("^[a-zA-Z -]+$", ErrorMessage = "Alleen letters, spaties en streepjes graag")]
		public string Name { get; set; }

		[Range(1, 200)]
		public decimal Speed { get; set; } // kilometers per hour

		public bool Scored { get; set; }

		public string PhotoFace { get; set; }
	}
}
