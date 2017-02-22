using HRM.DAL.DomainValue;
using HRM.DAL.EF;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRM.DAL.DbContext
{
    public class HRMContext:System.Data.Entity.DbContext
    {
        public HRMContext() : base(string.Format("HRMContext", DbConnection.HRMContext)) { }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StatusType> StatusType { get; set; }
        public virtual DbSet<UserLevel> UserLevel { get; set; }
        public virtual DbSet<UserTeam> UserTeam { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserDocument> UserDocument { get; set; }
        public virtual DbSet<UserRequest> UserRequest { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<RequestType> RequestType { get; set; }
        public virtual DbSet<OfficialHollidays> OfficialHollidays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Configurations.Add(new TeamMap());

            modelBuilder.Configurations.Add(new UserMap());

           // modelBuilder.Configurations.Add(new UserLevelMap());

           //modelBuilder.Configurations.Add(new RoleMap());

           // modelBuilder.Configurations.Add(new OfficialHollidaysMap());
         
           // modelBuilder.Configurations.Add(new SettingsMap());

           // modelBuilder.Configurations.Add(new StatusTypeMap());

            //modelBuilder.Configurations.Add(new UserDocumentMap());

            //modelBuilder.Configurations.Add(new UserRequestMap());

            //modelBuilder.Configurations.Add(new UserTeamMap());

            //modelBuilder.Configurations.Add(new RequestTypeMap());

            //modelBuilder.Configurations.Add(new UserRoleMap());

            //modelBuilder.Entity<User>()
            //   .HasMany<Team>(t => t.Teams)
            //   .WithMany(u => u.User)
            //   .Map(tu =>
            //            {
            //                tu.MapLeftKey("UserId");
            //                tu.MapRightKey("TeamId");
            //                tu.ToTable("UserTeam");


            //            });
            

         



        }
    }
}
