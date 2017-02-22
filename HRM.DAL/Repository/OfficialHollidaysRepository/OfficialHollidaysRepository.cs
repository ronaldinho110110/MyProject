using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
   public class OfficialHollidaysRepository : Repository<OfficialHollidays>, IOfficialHollidaysRepository
    {
        public OfficialHollidaysRepository(IUnitOfWork context) : base(context)
        {
        }


        public OfficialHollidays GetOffHolldayByID(int? Id)
        {
            return _unitOfWork.Context.OfficialHollidays.Where(e => e.Id == Id).FirstOrDefault<OfficialHollidays>();
  
        }
    }
}
