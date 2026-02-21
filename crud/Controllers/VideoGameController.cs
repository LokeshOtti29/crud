using crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static List<Character> characters = new List<Character>
        {
                new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Protagonist" },
                new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
                new Character { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Protagonist" }
        };

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
        {
            return await Task.FromResult(Ok(characters));
        }
    }
}
