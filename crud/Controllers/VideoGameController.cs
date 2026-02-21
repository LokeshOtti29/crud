using crud.Models;
using crud.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {

        private readonly IVideoGameCharacterServices _service;

        public VideoGameController(IVideoGameCharacterServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
        {
            var characters = await _service.GetCharacterAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        {
            var character = await _service.GetCharacterByIdAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return Ok(character);
        }
    }
}
