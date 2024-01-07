using Microsoft.AspNetCore.Mvc;


namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("demo")]
    public class TesteController: ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Carlos Tavares" });
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            return CreatedAtAction("Get", new { id = produto.Id}, produto);
            // é usado para retornar 201 e oferece um método para ter acesso ao produto que foi criado acima
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            if(id != produto.Id) { return BadRequest(); }

            return NoContent();
            //NoContent idica o status 204
        }

    }
}
