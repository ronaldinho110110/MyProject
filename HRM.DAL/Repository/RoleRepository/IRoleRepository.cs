﻿using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repository.RoleRepository
{
    interface IRoleRepository:IRepository<Role>
    {
        Role GetRoleById(int? Id);
    }
}
