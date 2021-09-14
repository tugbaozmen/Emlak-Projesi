using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class City: EntityBase
    {
        public City()
        {
            Estates = new HashSet<Estate>();
            Counties = new HashSet<County>();
        }
        public int CityId { get; set; }
        [Required]
        [DisplayName("Şehir")]
        public string CityName { get; set; }



        public ICollection<Estate> Estates { get; set; }
        public ICollection<County> Counties { get; set; }
    }
}
