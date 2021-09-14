using System;
using System.Collections.Generic;
using System.Text;

namespace EstateProject.Entities
{
    public class UserRole:EntityBase
    {
        public int UserRoleId { get; set; }
        public long UserId { get; set; }
        public int RoleId { get; set; }


        public User User { get; set; }
        public Role Role { get; set; }
    }
}
