using BackEnd.Dtos;

namespace BackEnd.Repos
{
    public interface IMontyHallProblemRepo
    {
        SimulationsResult GetSimulationResults(UserInput userInput);
    }
}
