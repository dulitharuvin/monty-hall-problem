using BackEnd.Api.Dtos;

namespace BackEnd.Tests.MockData;

public class MontyHallProblemMockData
{

    public static SimulationsResult GetSimulationsResult()
    {
        return new SimulationsResult
        {
            NumberOfWins = 6691,
            NumberOfLoses = 3309,
            NumerOfSimulations = 10000,
            WinRatio = 66
        };
    }

    public static SimulationsResult GetSimulationsResultAsNull()
    {
        return null;
    }

    public static UserInput GetUserInput()
    {
        return new UserInput
        {
            NumberOfSimulations = 100,
            ChangeSelectedDoor = true
        };
    }

    public static UserInput GetEmptyUserInput()
    {
        return new UserInput();
    }
}