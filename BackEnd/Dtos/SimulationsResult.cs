namespace BackEnd.Dtos
{
    public class SimulationsResult
    {
        int NumberOfWins { get; set; }

        int NumberOfLoses { get; set; }

        int NumerOfSimulations { get; set; }

        decimal WinRatio { get; set; }
    }
}
