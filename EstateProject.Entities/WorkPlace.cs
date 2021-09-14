using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class WorkPlace:EntityBase
    {
        public WorkPlace()
        {
            //UserWorkPlaces =new HashSet<UserWorkPlace>();
            Estates = new HashSet<Estate>();
        }
        public long WorkPlaceId { get; set; }
        [Required]
        [MaxLength(250)]
        [DisplayName("Adres")]
        public string Address { get; set; }
        [Required]
        [MaxLength(11)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [Required]
        [MaxLength(11)]
        [DisplayName("Fax")]
        public string FaxNumber { get; set; }
        [Required]
        [MaxLength(150)]
        [DisplayName("İş Yeri Adı")]
        public string BusinessName { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Yetkili Adı")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Yetkili Soyadı")]
        public string LastName { get; set; }


        //public ICollection<UserWorkPlace> UserWorkPlaces { get; set; }
        public ICollection<Estate> Estates { get; set; }
    }
}
