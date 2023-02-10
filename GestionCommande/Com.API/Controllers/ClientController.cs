using Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Com.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService  _clientService;
        private readonly ILogger<ClientController> _logger;


        public ClientController(
            ILogger<ClientController> logger,
            IClientService clientService
            )
        {
            _logger = logger;
            _clientService = clientService;
        }


        // GET: api/<Client>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Client>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Client>
        [HttpPost]
        public IActionResult Post([FromBody] ClientCreateDto obj)
        {
            try
            {
                return Ok( _clientService.Create(obj));
            }
            catch (Exception ex)
            {
                var msg = ex.ToString();
                return NotFound(msg);
                return BadRequest(msg);
               // _logger.
            }
        }

        // PUT api/<Client>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Client>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
