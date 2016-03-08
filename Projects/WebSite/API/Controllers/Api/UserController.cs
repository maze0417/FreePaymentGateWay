using System.ComponentModel;
using System.Threading.Tasks;
using System.Web.Http;
using EME.Application.Interfaces;
using EME.Application.Responses.UserService;

namespace EME.WebApi.Controllers.Api
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet, Route, Description("Get admin users")]
        public async Task<GetUserResponse> GetUsersAsync([FromUri]  string name)
        {
            return await _userService.GetUserByUsernameAsync(name);
        }
    }
}