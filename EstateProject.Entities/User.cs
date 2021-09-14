using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class User: EntityBase
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            //UserWorkPlaces = new HashSet<UserWorkPlace>();
            Estates = new HashSet<Estate>();
        }
        public long UserId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Ad")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Soyad")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(11)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }
     
        [MaxLength(11)]
        [DisplayName("Ev Telefonu")]
        public string HomePhone { get; set; }

        [Required]
        [MaxLength(120)]
        [EmailAddress]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(10)]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }
        //public ICollection<UserWorkPlace> UserWorkPlaces { get; set; }
        public ICollection<Estate> Estates { get; set; }
    }
}
