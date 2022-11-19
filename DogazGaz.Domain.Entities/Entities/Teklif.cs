using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;

namespace DogalGaz.Domain.Entities.Entities
{
    public class Teklif : EntitiesModel,IEntity
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public DateTime? TeklifTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int? Tutar { get; set; }
        public int? Iskonto { get; set; }
        public int? OdenecekTutar { get; set; }
        //public int? OdemeTipiID { get; set; }
        public int? TeklifDurum { get; set; }       
        public bool IsDeleted { get; set; }

    }
}
