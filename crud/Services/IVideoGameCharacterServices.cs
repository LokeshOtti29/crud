using crud.Dtos;
using crud.Models;

namespace crud.Services
{
    public interface IVideoGameCharacterServices
    {
        Task<List<CharacterResponse>> GetCharacterAsync();
        Task<CharacterResponse?> GetCharacterByIdAsync(int id);

        Task<CharacterResponse> AddCharacterAsync(CreateCharacterResponse character);
        Task<bool> UpdateCharacterAsync(int id, UpdateCharacterResponse character);
        Task<bool> DeleteCharacterAsync(int id);

    }
}
