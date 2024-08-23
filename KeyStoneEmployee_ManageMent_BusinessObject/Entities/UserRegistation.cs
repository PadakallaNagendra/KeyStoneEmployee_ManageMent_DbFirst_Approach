using System;
using System.Collections.Generic;

namespace KeyStoneEmployee_ManageMent_BusinessObject
{
    public partial class UserRegistation
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public string? Passwrod { get; set; }
    }
}
