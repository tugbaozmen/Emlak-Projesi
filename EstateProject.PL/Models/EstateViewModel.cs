using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Models
{
    public class EstateViewModel
    {
        public int EstateId { get; set; }
        [Required]
        [MaxLength(250)]
        [DisplayName("Emlak(Konut) Adı")]
        public string EstateName { get; set; }
        [Required]
        [DisplayName("Oda Sayısı")]
        public int NumberOfRoom { get; set; }
        [Required]
        [DisplayName("Balkon Sayısı")]
        public int NumberOfBalcony { get; set; }
        [Required]
        [DisplayName("Banyo Sayısı")]
        public int NumberOfBathromm { get; set; }
        [Required]
        [DisplayName("Tuvalet Sayısı")]
        public int NumberOfToilet { get; set; }
        [Required]
        [DisplayName("Binanın Kat Sayısı")]
        public int NumberOfFloor { get; set; }
        [Required]
        [DisplayName("Kaçıncı Kat")]
        public int FloorStatus { get; set; }
        [Required]
        [DisplayName("Isınma")]
        public WarmStatus WarmStatus { get; set; }
        [Required]
        [DisplayName("Cephe")]
        public Front Front { get; set; }
        [Required]
        [DisplayName("Emlak Durumu")]
        public EstateStatus EstateStatus { get; set; }
        [Required]
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
        public long UserId { get; set; }
        [DisplayName("Konut Sahibi Adı")]
        public string HostName { get; set; }
        public int CityId { get; set; }
        [DisplayName("İl")]
        public string CityName { get; set; }
        public int CountyId { get; set; }
        [DisplayName("İlçe")]
        public string CountyName { get; set; }
        public long WorkPlaceId { get; set; }
        [DisplayName("Emlakçı Adı")]
        public string BusinessName { get; set; }
        public int EstateTypeId { get; set; }
        [DisplayName("Konut Tipi")]
        public string Name { get; set; }

    }
}
