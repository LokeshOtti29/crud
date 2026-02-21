using crud.Models;

namespace crud.Services
{
    public interface IVideoGameCharacterServices
    {
        Task<List<Character>> GetCharacterAsync();
        Task<Character> GetCharacterByIdAsync(int id);

        Task<Character> AddCharacterAsync();
        Task<bool> UpdateCharacterAsync();
        Task<bool> DeleteCharacterAsync(int id);

    }
}
