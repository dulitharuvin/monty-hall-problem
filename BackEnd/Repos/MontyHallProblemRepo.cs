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
            return "Test Done";
        }
    }
}
