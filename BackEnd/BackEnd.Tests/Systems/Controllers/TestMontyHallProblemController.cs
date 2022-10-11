using Xunit;
using Moq;
using FluentAssertions;
using BackEnd.Api.Repos;
using BackEnd.Api.Controllers;
using BackEnd.Tests.MockData;
using Microsoft.AspNetCore.Mvc;

namespace ackEnd.Tests.Systems.Controllers
{

    public class TestMontyHallProblemController
    {

        [Fact]
        public async Task GetSimulationResults_ShouldReturn200Status()
        {
            ///Arrange
            var repository = new Mock<IMontyHallProblemRepo>();
            var userInput = MontyHallProblemMockData.GetUserInput();
            var simulationResult = MontyHallProblemMockData.GetSimulationsResult();
            repository.Setup(_ => _.GetSimulationResults(userInput)).ReturnsAsync(simulationResult);
            var sut = new MontyHallProblemController(repository.Object);

            ///Act
            var result = (OkObjectResult)await sut.GetSimulationResults(userInput);

            // /// Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task GetSimulationResults_ShouldReturn204NoContentStatus()
        {
            ///Arrange
            var repository = new Mock<IMontyHallProblemRepo>();
            var emptyUserInput = MontyHallProblemMockData.GetEmptyUserInput();
            var nullSimulationResult = MontyHallProblemMockData.GetSimulationsResultAsNull();
            repository.Setup(_ => _.GetSimulationResults(emptyUserInput)).ReturnsAsync(nullSimulationResult);
            var sut = new MontyHallProblemController(repository.Object);

            ///Act
            var result = (NoContentResult)await sut.GetSimulationResults(emptyUserInput);

            // /// Assert
            result.StatusCode.Should().Be(204);
        }

        [Fact]
        public async Task GetSimulationResults_ShouldCallRepoGetSimulationResultsOnce()
        {
            ///Arrange
            var repository = new Mock<IMontyHallProblemRepo>();
            var userInput = MontyHallProblemMockData.GetUserInput();
            var sut = new MontyHallProblemController(repository.Object);

            ///Act
            var result = await sut.GetSimulationResults(userInput);

            ///Assert
            repository.Verify(_ => _.GetSimulationResults(userInput), Times.Exactly(1));
        }
    }
}