using KeyStoneEmployee_ManageMent_BusinessObject.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployee_ManageMent_BusinessObject.InterFace
{
    public interface IUserService
    {
        public Task<List<UserRegistationDTO>> GetAllRegistation();
        public Task<UserRegistationDTO> GetUserRegistationById(int id);
        public Task<bool> UpdateUserRegistation(UserRegistationDTO userRegistationDto);
        public Task<bool> DeleteUserRegistationById(int id);
        public Task<bool> AddUserdetails(UserRegistationDTO userRegistationDto);
    }
}
