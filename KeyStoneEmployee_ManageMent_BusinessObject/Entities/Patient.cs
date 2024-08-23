using System;
using System.Collections.Generic;

namespace KeyStoneEmployee_ManageMent_BusinessObject
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Date { get; set; }
    }
}
