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
        public async Task<IActionResult> GetSimulationResults([FromBody] UserInput userInput)
        {
            var results = await _repository.GetSimulationResults(userInput);
            if (results == null)
            {
                return NoContent();
            }
            return Ok(results);
        }
    }
}
