using System.Data.Entity;
using System.Threading.Tasks;
using FreePayment.Core.Interfaces.DbRepositories;
using FreePayment.Core.Interfaces.DbRepositories.Queries;
using FreePayment.Data.Models.DbEntities;
using FreePayment.Data.Models.Enums;

namespace FreePayment.Data.DbRepositories.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly IDbRepository _dbRepository;

        public UserQueries(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        Task<User> IUserQueries.GetUserByUsernameAsync(string username)
        {
            return _dbRepository
                    .Users
                    .SingleOrDefaultAsync(a => a.Username == username && a.Status != UserStatus.Archived);
        }
    }
}