using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class County:EntityBase
    {
        public int CountyId { get; set; }
        [Required]
        [DisplayName("İlçe")]
        public string CountyName { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
    }
}
