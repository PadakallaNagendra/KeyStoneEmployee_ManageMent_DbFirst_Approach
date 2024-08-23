using System;
using System.Collections.Generic;

namespace KeyStoneEmployee_ManageMent_BusinessObject
{
    public partial class Booking
    {
        public int? Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Location { get; set; }
        public DateTime? Date { get; set; }
    }
}
