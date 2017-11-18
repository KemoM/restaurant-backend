using RestaurantAPI.DAL.Entities;
using RestaurantAPI.DAL.Interfaces;
using RestaurantAPI.Dtos;
using RestaurantAPI.Services.Interfaces;
using System;

namespace RestaurantAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Authenticate(string username, string password)
        {
            User user = _userRepository.Authenticate(username, password);

            if (user == null)
                return null;

            return new UserDto
            {
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName,
                Username = user.Username
            };
        }

        public UserDto Create(UserDto user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required");

            User userEntity = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username
            };

            User result = _userRepository.Create(userEntity, password);

            user.Id = result.Id;
            return user;
        }
    }
}
