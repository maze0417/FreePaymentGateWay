using EME.Application.Responses.UserService;
using EME.Data.Models.DbEntities;

namespace EME.Application.Mappers
{
    public class UserMapper
    {
        public GetUserResponse Response(User user)
        {
            return new GetUserResponse
            {
                Email = user.Email,
                Firstname = user.Firstname,
                Id = user.Id,
                Lastname = user.Lastname,
                Password = user.Password,
                Role = user.Role,
                Salt = user.Salt,
                Status = user.Status,
                Username = user.Username
            };
        }
    }
}