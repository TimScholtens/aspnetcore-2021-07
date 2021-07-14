using DemoProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoProject.Repositories
{
	public interface IPlayerRepository
	{
		Task<IEnumerable<PlayerModel>> GetAllAsync();
	}
}