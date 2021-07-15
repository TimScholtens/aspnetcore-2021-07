using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class PenaltyModel
    {
		public int Id { get; set; }

		[Required]
		public int PlayerId { get; set; }

		public PlayerModel Player { get; set; }

		[Range(1, 200)]
		public decimal Speed { get; set; } // kilometers per hour

		[Required]
		public bool Scored { get; set; }

		[Required]
		public string PhotoFace { get; set; }
	}
}
