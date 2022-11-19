using Base.Entities.Request;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Dto.LK;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request.Teklif
{
    public class TeklifUpdateRequest : IRequest
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public DateTime TeklifTarihi { get; set; }
        public string Adres { get; set; }
        public int Iskonto { get; set; }
        public int Tutar { get; set; }
        public int OdenecekTutar { get; set; }
        public int TeklifDurum { get; set; }


        //public List<DogalGazTesisatDetayDto> dogalGazTesisatDetayList { get; set; }
        //public List<RadyatorDetayDto> radyatorDetayList { get; set; }
        //public List<KombiModelDetayDto> kombiModelDetayList { get; set; }
        //public List<SobaModelDetayDto> sobaModelDetayList { get; set; }
        //public List<DigerDetayDto> digerDetayList { get; set; }

    }
}
