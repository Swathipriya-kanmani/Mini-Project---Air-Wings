using System;
using System.Collections.Generic;

namespace AirlinesProject.Models
{
    public partial class AirplaneInfo
    {
        public string PlaneId { get; set; } = null!;
        public string? AirplaneName { get; set; }
        public int? SeatingCapacity { get; set; }
        public decimal? Price { get; set; }
    }
}
