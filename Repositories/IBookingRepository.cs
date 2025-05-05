using AirBnb.Models;

namespace AirBnb.Repositories
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByUserAsync(int userId);
        Task<IEnumerable<Booking>> GetBookingsByPropertyAsync(int propertyId);
        Task<Booking> GetBookingWithDetailsAsync(int bookingId);
    }
}