using System.Threading.Tasks;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Core.Interfaces.DbRepositories.Queries
{
    public interface IUserQueries
    {
        Task<User> GetUserByUsernameAsync(string username);
    }
}