using BackEnd.Api.Dtos;

namespace BackEnd.Api.Repos
{
    public interface IMontyHallProblemRepo
    {
        SimulationsResult GetSimulationResults(UserInput userInput);
    }
}
