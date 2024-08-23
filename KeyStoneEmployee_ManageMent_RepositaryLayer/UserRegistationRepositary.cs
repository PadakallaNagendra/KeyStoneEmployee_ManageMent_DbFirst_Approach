using KeyStoneEmployee_ManageMent_BusinessObject;
using KeyStoneEmployee_ManageMent_BusinessObject.InterFace;
using KeyStoneEmployee_ManageMent_BusinessObject.ModelDTO;
using KeyStoneEmployee_ManageMent_DataBaseLogic.DbConnect;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployee_ManageMent_RepositaryLayer
{
    public class UserRegistationRepositary : IUserRepositary
    {
        public NagendraDBContext _DbContext;
        public UserRegistationRepositary(NagendraDBContext dbContext)
        {
            _DbContext =  dbContext;
        }
        public  async Task<bool> AddUserdetails(UserRegistation userRegistation)
        {
           await _DbContext.UserRegistations.AddAsync(userRegistation);
            _DbContext.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteUserRegistationById(int id)
        {
           UserRegistation a=await _DbContext.UserRegistations.SingleOrDefaultAsync(e=>e.Id==id);
            if (a != null)
            {
               _DbContext.UserRegistations.Remove(a);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<UserRegistation>> GetAllRegistation()
        {
            var user = await _DbContext.UserRegistations.ToListAsync();
            if (user.Count == 0)
                return null;
            else
                return user;

        }

        public async Task<UserRegistation> GetUserRegistationById(int id)
        {
            var rm = await _DbContext.UserRegistations.Where(e => e.Id ==id).FirstOrDefaultAsync();

            if (rm == null)
                return null;
            else
                return rm;
        }

        public async Task<bool> UpdateUserRegistation(UserRegistation userRegistation)
        {
            _DbContext.UserRegistations.Update(userRegistation);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
