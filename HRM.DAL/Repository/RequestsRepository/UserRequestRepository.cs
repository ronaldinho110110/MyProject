using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;

namespace HRM.DAL.Repository.TeamRepository
{
    public class UserRequestRepository : Repository<UserRequest>
    {
        public UserRequestRepository(IUnitOfWork context) : base(context)
        {
        }
     



}
  
}
