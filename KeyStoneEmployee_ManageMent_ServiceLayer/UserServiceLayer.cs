using KeyStoneEmployee_ManageMent_BusinessObject;
using KeyStoneEmployee_ManageMent_BusinessObject.InterFace;
using KeyStoneEmployee_ManageMent_BusinessObject.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployee_ManageMent_ServiceLayer
{
    public class UserServiceLayer : IUserService
    {
        public IUserRepositary _userRepositary;
        public UserServiceLayer(IUserRepositary userRepositary)
        {
            _userRepositary = userRepositary;
        }
        public async Task<bool> AddUserdetails(UserRegistationDTO userRegistationDto)
        {
            UserRegistation obj = new UserRegistation();
            obj.Id = userRegistationDto.Id;
            obj.Username = userRegistationDto.Username;
            obj.Email = userRegistationDto.Email;
            obj.Fullname = userRegistationDto.Fullname;
            obj.Passwrod=userRegistationDto.Passwrod;
           await _userRepositary.AddUserdetails(obj);
            return true;
        }

        public async Task<bool> DeleteUserRegistationById(int id)
        {
           await _userRepositary.DeleteUserRegistationById(id);
            return true;
        }

        public async Task<List<UserRegistationDTO>> GetAllRegistation()
        {
            List<UserRegistationDTO> objurreg = new List<UserRegistationDTO>();
            var result = await _userRepositary.GetAllRegistation();
            foreach (UserRegistation usrpbj in result)
            {
                UserRegistationDTO obj = new UserRegistationDTO();
                obj.Id = usrpbj.Id;
                obj.Fullname = usrpbj.Fullname;
                obj.Username = usrpbj.Username;
                obj.Email = usrpbj.Email;
                obj.Passwrod = usrpbj.Passwrod;
                objurreg.Add(obj);
            }
            return objurreg;
        }

        public async Task<UserRegistationDTO> GetUserRegistationById(int id)
        {
           
            var a = await _userRepositary.GetUserRegistationById(id);
            UserRegistationDTO user = new UserRegistationDTO();
            user.Id = a.Id;
            user.Fullname = a.Fullname;
            user.Username = a.Username;
            user.Email = a.Email;
            user.Passwrod=a.Passwrod;
            return user;
        }

        public async Task<bool> UpdateUserRegistation(UserRegistationDTO userRegistationDto)
        {
            UserRegistation obj = new UserRegistation();
            obj.Id = userRegistationDto.Id;
            obj.Fullname = userRegistationDto.Fullname;
            obj.Username = userRegistationDto.Username;
            obj.Passwrod = userRegistationDto.Passwrod;
            obj.Email = userRegistationDto.Email;

            
            await _userRepositary.UpdateUserRegistation(obj);
            return true;
        }

        
    }
}
