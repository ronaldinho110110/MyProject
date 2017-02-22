using System.Collections.Generic;

namespace HRM.DAL.Models
{
    public class User : BaseModel
    {
        public User()
        {
            UserDocuments = new HashSet<UserDocument>();
            Requests = new HashSet<UserRequest>();
            Roles = new HashSet<Role>();
            Teams = new HashSet<Team>();
        }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public System.DateTime? StartDate{ get; set; }         
        public int? StatusId { get; set; }
        public int? UserLevelId { get; set; }
        public int? UserDocumentId { get; set; }
        public int? RoleTypeId { get; set; }
        public int? TeamId { get; set; }

        public virtual UserLevel UserLevel { get; set; }
        public virtual ICollection<UserDocument> UserDocuments { get; set; }
        public virtual ICollection<UserRequest> Requests { get; set; } 
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
