using System;

namespace ECOAPP.Core.Dto.UserManagement
{
    public class HitUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}";
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
