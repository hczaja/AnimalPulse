using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.ValueObjects;

namespace AnimalPulse.Core.Repositories;

public interface IUserRepository
{
    Task<User> GetUserAsync(UserId id);
    Task<User> GetUserByUsernameAsync(UserId id);
    Task AddUser(User user);
}
