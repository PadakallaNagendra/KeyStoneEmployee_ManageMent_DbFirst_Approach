using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployee_ManageMent_BusinessObject.ModelDTO
{
    public class UserRegistationDTO
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public string? Passwrod { get; set; }
    }
}
