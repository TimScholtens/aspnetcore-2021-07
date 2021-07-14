using DemoProject.Models;
using DemoProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Tests
{
	public class NepPenaltyRepo : IPenaltyRepository
	{
		public bool HasAddAsyncBeenCalled { get; set; }
		public bool HasGetAllAsyncBeenCalled { get; set; }

		public Task<PenaltyModel> AddAsync(PenaltyModel newPenalty)
		{
			HasAddAsyncBeenCalled = true;
			return Task.FromResult<PenaltyModel>(null);
		}

		public Task<IEnumerable<PenaltyModel>> GetAllAsync()
		{
			HasGetAllAsyncBeenCalled = true;
			return Task.FromResult<IEnumerable<PenaltyModel>>(null);
		}
	}
}
