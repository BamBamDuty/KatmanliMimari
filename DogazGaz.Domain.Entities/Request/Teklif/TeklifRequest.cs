using Base.Entities.Request;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Dto.LK;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request.Teklif
{
    public class TeklifRequest : IRequest
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public DateTime TeklifTarihi { get; set; }
        public string Adres { get; set; }
        public int DogalGazTesisatID { get; set; }
        public int DogalGazTesisatTutar { get; set; }
        public int RadyatorID { get; set; }
        public int RadyatorMetre { get; set; }
        public int RadyatorTutar { get; set; }
        public int KombiMarkaID { get; set; }
        public int KombiModelID { get; set; }
        public int KombiTutar { get; set; }
        public int SobaMarkaID { get; set; }
        public int SobaModelID { get; set; }
        public int SobaTutar { get; set; }
        public List<DigerDto> DigerList { get; set; }
        public int Iskonto { get; set; }
        public int Tutar  { get; set; }
        public string ImageURL { get; set; }
        public int OdenecekTutar { get; set; }


    }
}
