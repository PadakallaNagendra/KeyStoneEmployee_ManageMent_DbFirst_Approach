using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployee_ManageMent_BusinessObject.InterFace
{
    public interface IUserRepositary
    {
        public Task<List<UserRegistation>> GetAllRegistation();
        public Task<UserRegistation> GetUserRegistationById(int id);
        public Task<bool> UpdateUserRegistation(UserRegistation userRegistation);
        public Task<bool> DeleteUserRegistationById(int id);
        public  Task<bool> AddUserdetails(UserRegistation userRegistation);
    }
}
