using crud.Models;

namespace crud.Services
{
    public interface IVideoGameCharacterServices
    {
        Task<List<Character>> GetCharacterAsync();
        Task<Character?> GetCharacterByIdAsync(int id);

        Task<Character> AddCharacterAsync(Character character);
        Task<bool> UpdateCharacterAsync(int id, Character character);
        Task<bool> DeleteCharacterAsync(int id);

    }
}
