using BackEnd.Api.Dtos;
using BackEnd.Api.Repos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Api.Controllers
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
