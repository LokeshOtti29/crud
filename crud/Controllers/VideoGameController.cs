using crud.Dtos;
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
        public async Task<ActionResult<List<CharacterResponse>>> GetCharacters()
        {
            var characters = await _service.GetCharacterAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterResponse>> GetCharacterById(int id)
        {
            var character = await _service.GetCharacterByIdAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<CreateCharacterResponse>> AddCharacter(CreateCharacterResponse character)
        {
            var newCharacter = await _service.AddCharacterAsync(character);
            return CreatedAtAction(nameof(GetCharacterById), new { id = newCharacter.Id }, newCharacter);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCharacter(int id, UpdateCharacterResponse character)
        {
            var result = await _service.UpdateCharacterAsync(id, character);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            var result = await _service.DeleteCharacterAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
