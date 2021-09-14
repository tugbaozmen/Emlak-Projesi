using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class Role: EntityBase
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }

        [Required]
        [MaxLength(150)]
        [DisplayName("Kullanıcı Rolü")]
        public string Name { get; set; }
        public string Description { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }

    }
}
