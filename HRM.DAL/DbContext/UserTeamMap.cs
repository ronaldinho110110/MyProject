﻿using HRM.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace HRM.DAL.EF
{
    public class UserTeamMap : EntityTypeConfiguration<UserTeam>
    {
        public UserTeamMap()
        {
            ToTable("UserTeam", "hrm").HasKey(t => t.Id);
        }
  
    }
}
