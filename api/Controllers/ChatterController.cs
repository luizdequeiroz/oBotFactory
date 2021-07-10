using domain.Entities;
using Microsoft.AspNetCore.Mvc;
using service;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatterController : ControllerBase
    {
        private readonly IChatterService chatterService;

        public ChatterController(IChatterService chatterService)
        {
            this.chatterService = chatterService;
        }

        [HttpGet]
        public IActionResult ListAll()
        {
            var chatters = chatterService.GetAll();

            if (chatters.Count == 0)
                return NoContent();

            return Ok(chatters);
        }

        [HttpPost]
        public IActionResult CreateNew(Chatter chatter)
        {
            var chatterInserted = chatterService.SetNew(chatter);

            if (chatterInserted == null)
                return BadRequest();

            return Ok(chatterInserted);
        }
    }
}
