using BackEnd.Dtos;
using BackEnd.Repos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MontyHallProblemController : ControllerBase
    {
        private readonly IMontyHallProblemRepo _repository;

        public MontyHallProblemController(IMontyHallProblemRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<SimulationsResult> GetSimulationResults([FromBody] UserInput userInput)
        {
            return _repository.GetSimulationResults(userInput);
        }
    }
}
