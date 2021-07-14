using DemoProject.Controllers;
using DemoProject.Models;
using DemoProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace DemoProject.Tests
{
	[TestClass]
	public class PenaltyControllerTest
	{
		Mock<IPenaltyRepository> mockPenaltyRepo;
		Mock<IPlayerRepository> mockPlayerRepo;
		PenaltyController sut;

		[TestInitialize]
		public void Initialize()
		{
			//mockPenaltyRepo = new NepPenaltyRepo(); // WHAT
			mockPenaltyRepo = new Mock<IPenaltyRepository>();
			mockPlayerRepo = new Mock<IPlayerRepository>();


			mockPenaltyRepo.Setup(x => x.GetAllAsync()).Returns(Task.FromResult(new List<PenaltyModel>
			{

			}.AsEnumerable()));

			// mock framework:
			// Moq
			// Rhino Mocks - oooooouuuuuuuddddddd

			// You Aren't Gonna Need It
			sut = new PenaltyController(mockPenaltyRepo.Object, mockPlayerRepo.Object); // System Under Test
		}

		[TestMethod]
		public async Task CreateWithInvalidModelShouldReturnViewWithErrors()
		{
			// Act
			sut.ModelState.AddModelError("q", "q"); // IsValid = false
			var result = await sut.Create(new PenaltyModel());

			// Assert
			Assert.IsInstanceOfType(result, typeof(ViewResult));
			mockPenaltyRepo.Verify(x => x.AddAsync(It.IsAny<PenaltyModel>()), Times.Never());
		}

		[TestMethod]
		public async Task CreateWithValidModelShouldAddAndRedirect()
		{
			var result = await sut.Create(new PenaltyModel());

			Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
			mockPenaltyRepo.Verify(x => x.AddAsync(It.IsAny<PenaltyModel>()), Times.Once());
		}
	}
}
