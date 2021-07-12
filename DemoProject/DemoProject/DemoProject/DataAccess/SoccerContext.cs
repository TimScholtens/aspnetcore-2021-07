using DemoProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess
{
    public class SoccerContext : DbContext
    {
		public DbSet<PenaltyModel> Penalties { get; set; }

		public SoccerContext(DbContextOptions options) : base(options)
		{

		}
	}
}
