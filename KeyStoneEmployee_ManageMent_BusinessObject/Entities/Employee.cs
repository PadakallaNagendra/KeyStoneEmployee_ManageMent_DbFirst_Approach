using System;
using System.Collections.Generic;

namespace KeyStoneEmployee_ManageMent_BusinessObject
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Ename { get; set; }
        public decimal? Salary { get; set; }
        public int? Did { get; set; }
        public int? Age { get; set; }
        public string? Location { get; set; }
        public string? Gender { get; set; }

       public virtual Department? DidNavigation { get; set; }
    }
}
