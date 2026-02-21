using crud.Models;

namespace crud.Services
{
    public class VideoGameCharacterServices:IVideoGameCharacterServices
    {
        static List<Character> characters = new List<Character>
        {
                new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Protagonist" },
                new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
                new Character { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Protagonist" },
                new Character { Id = 4, Name = "Master Chiefs", Game = "texasrunway", Role = "Protagonist" }
        };
        public Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Character>> GetCharacterAsync()
        {
            return await Task.FromResult(characters);
        }
        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            var charact = characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(charact);
        }
        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
