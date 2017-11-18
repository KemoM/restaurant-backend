using RestaurantAPI.DAL.Entities;

namespace RestaurantAPI.DAL.Interfaces
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
        User Create(User user, string password);
    }
}
