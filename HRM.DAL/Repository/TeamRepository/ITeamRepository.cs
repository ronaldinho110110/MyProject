﻿using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.TeamRepository
{
   public  interface ITeamRepository:IRepository<Team>
    {
        Team GetTeamById(int? Id);
        void RemoveMembers(Team team, User user);
    }
}
