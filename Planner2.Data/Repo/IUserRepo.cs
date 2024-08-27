using Planner2.Data.Models;

namespace Planner2.Data.Repo
{
    public interface IUserRepo
    {
        Task<User> CreateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUsersByIdAsync(int id);
        Task UpdateUserAsync(User user);
    }
}