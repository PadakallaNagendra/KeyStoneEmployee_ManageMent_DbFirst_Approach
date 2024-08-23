using System;
using System.Collections.Generic;


namespace KeyStoneEmployee_ManageMent_BusinessObject
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Did { get; set; }
        public string? Dname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
