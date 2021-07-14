using DemoProject.DataAccess;
using DemoProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Repositories
{
	public class PlayerRepository : IPlayerRepository
	{
		private SoccerContext context;
		public PlayerRepository(SoccerContext context)
		{
			this.context = context;
		}

		public async Task<IEnumerable<PlayerModel>> GetAllAsync()
		{
			return await context.Players.ToListAsync();
		}
	}
}
