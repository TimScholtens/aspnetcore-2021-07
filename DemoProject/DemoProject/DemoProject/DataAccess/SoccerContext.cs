using DemoProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess
{
    public class SoccerContext : IdentityDbContext<FanUserModel>
    {
		public DbSet<PenaltyModel> Penalties { get; set; }

		public DbSet<PlayerModel> Players { get; set; }

		// zodat de startup config hieraan doorgegeven wordt
		public SoccerContext(DbContextOptions options) : base(options)
		{

		}
	}
}
