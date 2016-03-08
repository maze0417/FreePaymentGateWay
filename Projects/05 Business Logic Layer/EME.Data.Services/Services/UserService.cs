using System.Data.Entity;
using System.Threading.Tasks;
using EME.Application.Interfaces;
using EME.Application.Mappers;
using EME.Application.Responses.UserService;
using EME.Data.Models.Enums;
using EME.Data.SqlRepositories;

namespace EME.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IDbRepository _dbRepository;
        private readonly UserMapper _userMapper= new UserMapper();
        public UserService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        async Task<GetUserResponse> IUserService.GetUserByUsernameAsync(string username)
        {
            var result =await _dbRepository
                .Users
                .SingleOrDefaultAsync(a => a.Username == username && a.Status != UserStatus.Archived);
            return _userMapper.Response(result);
        }
    }
}