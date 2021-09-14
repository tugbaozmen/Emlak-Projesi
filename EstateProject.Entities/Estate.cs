using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateProject.Entities
{
    public class Estate:EntityBase
    {
        public long EstateId { get; set; }
        [Required]
        [MaxLength(250)]
        [DisplayName("Adı")]
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
        public int CityId { get; set; }
        public long WorkPlaceId { get; set; }

        [ForeignKey("EstateType")]
        public int EstateTypeId { get; set; }

        public User User { get; set; }
        public City City { get; set; }
        public EstateType EstateType { get; set; }
        public WorkPlace WorkPlace { get; set; }
    }

    public enum WarmStatus:byte
    {
        Soba = 1,
        Merkezi = 2,
        Kombi = 3,
    }

    public enum Front:byte
    {
        Kuzey = 1,
        Güney = 2,
        Doğu = 3,
        Batı = 4,
    }

    public enum EstateStatus:byte
    {
        Kiralık = 1,
        Satılık = 2,
    }
}
