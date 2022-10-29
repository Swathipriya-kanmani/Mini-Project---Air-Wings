using System;
using System.Collections.Generic;

namespace AirlinesProject.Models
{
    public partial class FlightBooking
    {
        public string BookId { get; set; } = null!;
        public string? BookCusName { get; set; }
        public string? BookCusAddress { get; set; }
        public string BookCusEmail { get; set; } = null!;
        public int? BookCusSeats { get; set; }
        public string? BookCusPhoneNumber { get; set; }
        public int? BookCusCnic { get; set; }
        public string ReservationId { get; set; } = null!;
    }
}
