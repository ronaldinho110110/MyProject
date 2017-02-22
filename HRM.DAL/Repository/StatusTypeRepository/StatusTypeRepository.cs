using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.Models;

namespace HRM.DAL.Repository.StatusTypeRepository
{
    public class StatusTypeRepository : Repository<StatusType>, IStatusTypeRepository
    {
        public StatusTypeRepository(IUnitOfWork context) : base(context)
		{
        }    

        public StatusType GetStatusTypeByName(string name)
        {
            return _unitOfWork.Context.StatusType
                .Where(e => e.Name == name).FirstOrDefault<StatusType>();
        }

    }
}
