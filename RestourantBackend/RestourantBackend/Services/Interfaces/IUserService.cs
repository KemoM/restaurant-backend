using RestaurantAPI.Dtos;

namespace RestaurantAPI.Services.Interfaces
{
    public interface IUserService
    {
        UserDto Authenticate(string username, string password);
        UserDto Create(UserDto user, string password);
    }
}
