using System.Threading.Tasks;
using EME.Application.Responses.UserService;

namespace EME.Application.Interfaces
{
    public interface IUserService
    {
        Task<GetUserResponse> GetUserByUsernameAsync(string username);
    }
}