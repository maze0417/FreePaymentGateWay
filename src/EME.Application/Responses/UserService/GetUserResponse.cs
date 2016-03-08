using System;
using EME.Data.Models.Enums;
using EME.Infrastructure.Common.BaseModels;

namespace EME.Application.Responses.UserService
{
    public class GetUserResponse : ApiResponse
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public UserStatus Status { get; set; }
    }
}