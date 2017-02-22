using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;

namespace HRM.DAL.Repository.TeamRepository
{
    public class RequestTypeRepository : Repository<RequestType>
    {
        public RequestTypeRepository(IUnitOfWork context) : base(context)
        {
        }
        public UserRequest GetUserRequestTypeByName(string NameofRequestType)
        {
            return _unitOfWork.Context.UserRequest
                .Where(e => e.RequestType.Name == NameofRequestType).FirstOrDefault();

        }

    }
}
    

