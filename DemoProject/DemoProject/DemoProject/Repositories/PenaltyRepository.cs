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
	public class PenaltyRepository : IPenaltyRepository
	{
		private SoccerContext context;
		public PenaltyRepository(SoccerContext context)
		{
			// performance
			//context.Database.ExecuteSqlRaw("")
			this.context = context;
		}


		// C# is pascalcase
		// Java is camelcase


		public async Task<IEnumerable<PenaltyModel>> GetAllAsync()
		{
			return await context.Penalties.Include(x => x.Player).ToListAsync();
		}

		public async Task<PenaltyModel> AddAsync(PenaltyModel newPenalty)
		{
			context.Penalties.Add(newPenalty); // SQL injection is een stuk lastiger zo
			await context.SaveChangesAsync(); // thread optimalisatie: C10k problem
			return newPenalty; // Id property has been updated
		}
	}
}
