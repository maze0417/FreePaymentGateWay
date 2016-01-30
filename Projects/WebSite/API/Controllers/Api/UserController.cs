using System.ComponentModel;
using System.Threading.Tasks;
using System.Web.Http;
using FreePayment.Core.Interfaces.DbRepositories.Queries;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Data.API.Controllers.Api
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserQueries _userQueries;

        public UserController(IUserQueries userQueries)
        {
            _userQueries = userQueries;
        }

        [HttpGet, Route, Description("Get admin users")]
        public async Task<User> GetUsersAsync([FromUri]  string name)
        {
            return await _userQueries.GetUserByUsernameAsync(name);
        }
    }
}