using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Models
{
    public class CityCountyViewModel
    {
        public int CityId { get; set; }
        [DisplayName("İl")]
        public string CityName { get; set; }
        public int CountyId { get; set; }
        [DisplayName("İlçe")]
        public string CountyName { get; set; }
    }
}
