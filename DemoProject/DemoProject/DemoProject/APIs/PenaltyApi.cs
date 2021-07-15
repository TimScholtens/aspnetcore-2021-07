using DemoProject.Models;
using DemoProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.APIs
{
	[Route("api/penalty")]
	[ApiController]
	public class PenaltyApi : ControllerBase
	{
		private IPenaltyRepository penalRepo;
		private IPlayerRepository playerRepo;
		public PenaltyApi(IPenaltyRepository penalRepo, IPlayerRepository playerRepo)
		{
			this.penalRepo = penalRepo;
			this.playerRepo = playerRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<PenaltyModel>> Get()
		{
			return await penalRepo.GetAllAsync();
		}

		[HttpPost]
		public async Task<PenaltyModel> Post(PenaltyModel newPenalty) // model binding
		{
			await penalRepo.AddAsync(newPenalty); // Id wordt gezet
			return newPenalty;
		}

		// .NET Framework: WCF 3.0    .asmx

		// gRPC: gRPC Remote Procedure Call - recursieve definitie  PHP:  PHP Hypertext Preprocessor

	}
}
