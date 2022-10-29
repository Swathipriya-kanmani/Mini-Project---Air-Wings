using System;
using System.Collections.Generic;

namespace AirlinesProject.Models
{
    public partial class UserLogin
    {
        public string UserId { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
        public string? UserName { get; set; }
        public string Password { get; set; } = null!;
        public int? Age { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Cnic { get; set; }
    }
}
