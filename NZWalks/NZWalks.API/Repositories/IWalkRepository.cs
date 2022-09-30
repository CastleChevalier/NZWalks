using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        //since its async, we wrap it in a task
        Task<IEnumerable<Walk>> GetAllAsync();

        Task<Walk> GetAsync(Guid id);

        Task<Walk> AddAsync(Walk walk);

        Task<Walk> UpdateAsync(Guid id, Walk walk);

        Task<Walk> DeleteAsync(Guid id);
    }
}
