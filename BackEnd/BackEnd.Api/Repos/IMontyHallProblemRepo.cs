using BackEnd.Api.Dtos;

namespace BackEnd.Api.Repos
{
    public interface IMontyHallProblemRepo
    {
        Task<SimulationsResult> GetSimulationResults(UserInput userInput);
    }
}
