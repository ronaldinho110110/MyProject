using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;

namespace HRM.DAL.Repository.TeamRepository
{
    public class UserDocumentRepository :Repository<UserDocument>
    {
        public UserDocumentRepository(IUnitOfWork context) : base(context)
		{
      
        }
    }
}
