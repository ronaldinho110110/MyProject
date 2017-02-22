using System.Collections.Generic;

namespace HRM.DAL.Models
{
    public class Team:BaseModel
    {
        public Team() {
            Users = new HashSet<User>();
        }
        public string TeamName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
