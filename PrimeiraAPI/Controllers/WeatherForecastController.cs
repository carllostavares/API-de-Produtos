using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
   public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id1}/{id2}")]
        public IActionResult Get1(int id1, int id2)
        {
            return Ok();
        }
    }



}