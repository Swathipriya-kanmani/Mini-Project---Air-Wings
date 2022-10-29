using System;
using System.Collections.Generic;

namespace AirlinesProject.Models
{
    public partial class AdminLogin
    {
        public string AdminId { get; set; } = null!;
        public string? AdminName { get; set; }
        public string Password { get; set; } = null!;
    }
}
