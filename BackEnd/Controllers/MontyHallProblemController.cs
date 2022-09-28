using BackEnd.Dtos;
using BackEnd.Repos;
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

        [HttpGet]
        public ActionResult<object> GetSimulationResults([FromQuery] UserInput userInput)
        {            
            return _repository.GetSimulationResults(userInput);
        }
    }
}
