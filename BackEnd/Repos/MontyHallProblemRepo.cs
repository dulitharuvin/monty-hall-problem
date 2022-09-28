using BackEnd.Data;
using BackEnd.Dtos;

namespace BackEnd.Repos
{
    public class MontyHallProblemRepo : IMontyHallProblemRepo
    {
        private readonly AppDbContext _context;

        public MontyHallProblemRepo(AppDbContext context)
        {
            _context = context;
        }

        public object GetSimulationResults(UserInput userInput)
        {
            Random rand = new Random();

            int winCounter = 0;

            for (int i = 0; i < userInput.NumberOfSimulations; i++)
            {
                bool isWin = RunGame(rand, userInput.ChangeSelectedDoor);
                if (isWin)
                    winCounter++;
            }

            var results = new SimulationsResult
            {
                NumberOfWins = winCounter,
                NumberOfLoses = Math.Abs(userInput.NumberOfSimulations - winCounter),
                NumerOfSimulations = userInput.NumberOfSimulations,
                // WinRatio = (winCounter / userInput.NumberOfSimulations)
                WinRatio = decimal.Divide(winCounter, userInput.NumberOfSimulations) * 100
            };
            return results;
        }

        private bool RunGame(Random rand, bool doSwitch)
        {
            int doorWithCar = rand.Next(0, 3);
            int selection = rand.Next(0, 3);

            // available Doors
            List<Door> Doors = new List<Door> { new Door(), new Door(), new Door() };
            Doors[doorWithCar].IsCar = true;
            Doors[selection].IsSelected = true;
            Door selectedDoor = Doors[selection];
            int randomlyDisplayedDoor = rand.Next(0, 2);

            // one of the Doors are displayed
            var DoorsToDisplay = Doors.Where(x => !x.IsSelected && !x.IsCar);
            var displayedDoor = DoorsToDisplay.ElementAt(DoorsToDisplay.Count() == 1 ? 0 : randomlyDisplayedDoor);
            Doors.Remove(displayedDoor);

            // would you like to switch?
            if (Doors != null && doSwitch)
            {
                selectedDoor = Doors.Where(x => !x.IsSelected).Single();
                selectedDoor.IsSelected = true;
            }

            return selectedDoor.IsCar;
        }
    }
}
