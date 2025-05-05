using AirBnb.Models;

namespace AirBnb.Repositories
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<IEnumerable<Review>> GetReviewsByPropertyAsync(int propertyId);
        Task<IEnumerable<Review>> GetReviewsByUserAsync(int userId);
    }
}