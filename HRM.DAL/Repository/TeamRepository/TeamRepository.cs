using System;
using HRM.DAL.Models;
using HRM.DAL;
using System.Linq;

namespace HRM.DAL.Repository.TeamRepository
{
    public class TeamRepository :Repository<Team>, ITeamRepository
    {
        public TeamRepository(IUnitOfWork context) : base(context)
		{
        }
        public Team GetTeamById(int? Id)
        {
            return _unitOfWork.Context.Teams
                .Where(e => e.Id == Id).FirstOrDefault();
        }
        public override void RemoveStatus(Team team)
        {
            _unitOfWork.Context.Users.RemoveRange(team.Users);
            _unitOfWork.Context.Teams.Remove(team);

        }
        public void RemoveMembers(Team team,User user)
        {
            _unitOfWork.Context.Users.Remove(user);
            _unitOfWork.Context.Teams.Find(team.Id).Users.Remove(_unitOfWork.Context.Users.Find(user.Id));

        }
    }
}
