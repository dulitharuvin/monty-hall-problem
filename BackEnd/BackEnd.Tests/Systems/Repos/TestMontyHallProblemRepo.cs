using BackEnd.Api.Dtos;
using BackEnd.Api.Repos;
using BackEnd.Tests.MockData;
using FluentAssertions;
using Xunit;

namespace ackEnd.Tests.Systems.Repos
{

    public class TestMontyHallProblemRep
    {

        [Fact]
        public async Task GetSimulationResults_ShouldReturnTypeSimulationsResult()
        {
            ///Arrange
            var userInput = MontyHallProblemMockData.GetUserInput();
            var sut = new MontyHallProblemRepo();

            ///Act
            var result = await sut.GetSimulationResults(userInput);

            // /// Assert
            result.GetType().Should().Be(typeof(SimulationsResult));
        }
    }
}