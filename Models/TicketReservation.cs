using System;
using System.Collections.Generic;

namespace AirlinesProject.Models
{
    public partial class TicketReservation
    {
        public string ResId { get; set; } = null!;
        public string? ResForm { get; set; }
        public DateTime? ResDeptDate { get; set; }
        public DateTime? ResTime { get; set; }
        public string PlaneId { get; set; } = null!;
        public string? PlaneSeat { get; set; }
        public decimal? ResTicketPrice { get; set; }
        public string? ResPlaneType { get; set; }
    }
}
