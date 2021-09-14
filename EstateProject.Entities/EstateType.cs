using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstateProject.Entities
{
    public class EstateType:EntityBase
    {
        public EstateType()
        {
            //UserWorkPlaces =new HashSet<UserWorkPlace>();
            Estates = new HashSet<Estate>();
        }
        public int EstateTypeId { get; set; }
        /// <summary>
        /// Konut, İş Yeri, Arsa Tipi
        /// </summary>
        [Required]
        [MaxLength(50)]
        [DisplayName("Emlak Tipi")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Estate> Estates { get; set; }
    }
}
