using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Models
{
    public class UserRoleViewModel
    {
        //public User User { get; set; }
        //public Role Role { get; set; }

        public int RoleId { get; set; }
        [DisplayName("Rol Adı")]
        public string RoleName { get; set; }

        public int UserId { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string FirstName { get; set; }
        [DisplayName("Kullanıcı Soyadı")]
        public string LastName { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Ev Telefonu")]
        public string HomePhone { get; set; }
        [DisplayName("Mail")]
        [EmailAddress]
        public string UserName { get; set; }
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public int UserRoleId { get; set; }

    }
}
