﻿

namespace HRM.DAL.Models
{
    public class UserRole:BaseModel
    {
        public int? UserId { set; get; }
        public int? RoleId { set; get; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
