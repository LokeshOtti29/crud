using crud.Data;
using crud.Dtos;
using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Services
{
    public class VideoGameCharacterServices:IVideoGameCharacterServices
    {
        private readonly AddDbContext _context;
        public VideoGameCharacterServices(AddDbContext context)
        { 
                _context = context;
        }

        public async Task<CharacterResponse> AddCharacterAsync(CreateCharacterResponse character)
        {
            var newCharacter = new Character
            {
                Game = character.Game,
                Name = character.Name,
                Role = character.Role
            };
            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();
            return new CharacterResponse
            {
                Id = newCharacter.Id,
                Game = newCharacter.Game,
                Name = newCharacter.Name,
                Role = newCharacter.Role
            };
        }
        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var character = _context.Characters.Find(id);
            if (character == null)
            {
                return false;
            }
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<CharacterResponse>> GetCharacterAsync()
        {
            return await _context.Characters.Select(c=> new CharacterResponse 
            {
              Id=c.Id,
              Game=c.Game,
              Name=c.Name,
              Role=c.Role
            }).ToListAsync();

        }
        public async Task<CharacterResponse?> GetCharacterByIdAsync(int id)
        {
            var result = await _context.Characters.Where(c => c.Id == id).Select(c => new CharacterResponse
            {
                Id=c.Id,
                Game = c.Game,
                Name = c.Name,
                Role = c.Role
            }).FirstOrDefaultAsync();
            return result;
        }
        public async Task<bool> UpdateCharacterAsync(int id, UpdateCharacterResponse character)
        {
           var existingCharacter = await _context.Characters.FindAsync(id);
            if (existingCharacter == null)
            {
                return false;
            }
            existingCharacter.Game = character.Game;
            existingCharacter.Name = character.Name;
            existingCharacter.Role = character.Role;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
