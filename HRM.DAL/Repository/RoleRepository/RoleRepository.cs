using HRM.DAL.Models;
using System.Linq;

namespace HRM.DAL.Repository.RoleRepository
{
    class RoleRepository:Repository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork context) : base(context)
		{
    }
    public Role GetRoleById(int? Id)
    {
        return _unitOfWork.Context.Role
            .Where(e => e.Id == Id).FirstOrDefault();
    }
    public override void Remove(Role role)
    {
        _unitOfWork.Context.Users.RemoveRange(role.Users);
        _unitOfWork.Context.Teams.Remove(role);

    }        
    }
}
