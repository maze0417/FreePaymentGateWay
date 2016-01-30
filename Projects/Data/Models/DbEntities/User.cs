using System;
using FreePayment.Data.Models.Enums;

namespace FreePayment.Data.Models.DbEntities
{
    public class User : BaseTable
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