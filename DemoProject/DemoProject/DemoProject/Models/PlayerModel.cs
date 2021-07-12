using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class PlayerModel
    {
		public int Id { get; set; }

		[Required]
        [RegularExpression("^[a-zA-Z -]+$", ErrorMessage = "Alleen letters, spaties en streepjes graag")]
        public string Name { get; set; }
    }
}
