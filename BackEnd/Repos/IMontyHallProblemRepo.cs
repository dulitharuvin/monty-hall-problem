using BackEnd.Dtos;

namespace BackEnd.Repos
{
    public interface IMontyHallProblemRepo
    {
        object GetSimulationResults(UserInput userInput);
    }
}
