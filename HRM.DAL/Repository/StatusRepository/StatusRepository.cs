using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.Models;

namespace HRM.DAL.Repository.StatusRepository
{
    class StatusRepository : Repository<Status>, IStatusRepository
    {
        public StatusRepository(IUnitOfWork context) : base(context)
		{
        }

        public Status GetStatusById(int? Id)
        {
            return _unitOfWork.Context.Status
                .Where(e => e.Id == Id).FirstOrDefault<Status>();
        }
   
       
    }
}

