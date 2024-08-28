using Planner2.Data.Models;

namespace Planner2.Data.Repo
{
    public interface IUserRepo
    {
        Task<Users> CreateUserAsync(Users user);
        Task DeleteUserAsync(Users user);
        Task<IEnumerable<Users>> GetUsersAsync();
        Task<Users> GetUsersByIdAsync(int id);
        Task UpdateUserAsync(Users user);
    }
}