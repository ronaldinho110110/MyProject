using HRM.DAL.Models;
using HRM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public class UserRepository: Repository<User>,IUserRepository
    {
        public UserRepository(IUnitOfWork context) : base(context)
		{
        }
        public User GetByCredentials(string email, string password)
        {
            return _unitOfWork.Context.Users
                .Where(e => e.Email == email && e.Password == password)
                .FirstOrDefault();
        }
        public User GetByEmail(string email)
        {
            return _unitOfWork.Context.Users
                .Where(e => e.Email == email)
                .FirstOrDefault<User>();
        }
        public IEnumerable<User> GetTeamLead()
        {
            return _unitOfWork.Context.Users.Where(c => c.Roles.Any(t => t.Id == 2));
        }
        public IEnumerable<User> GetHR()
        {
            return _unitOfWork.Context.Users.Where(c => c.Roles.Any(t => t.Id == 3));
        }
    }
}
