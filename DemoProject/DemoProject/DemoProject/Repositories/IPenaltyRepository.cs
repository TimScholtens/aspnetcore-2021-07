using DemoProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoProject.Repositories
{
	public interface IPenaltyRepository
	{
		Task<PenaltyModel> AddAsync(PenaltyModel newPenalty);
		Task<IEnumerable<PenaltyModel>> GetAllAsync();
	}
}