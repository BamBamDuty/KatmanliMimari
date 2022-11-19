using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class TeklifDto : IDto
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public DateTime TeklifTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int RadyatorID { get; set; }
        public int DigerID { get; set; }
        public int Diger2ID { get; set; }
        public int Diger3ID { get; set; }
        public int KombiID { get; set; }
        public int SobaID { get; set; }
        public int Tutar { get; set; }
        public int Iskonto { get; set; }
        public int OdenecekTutar { get; set; }
        public int OdemeTipiıD { get; set; }
        public bool TeklifDurum { get; set; }
        public string ImageURL { get; set; }
    }
}
