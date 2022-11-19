using Base.Entities.Dtos;
using System;

namespace DogalGaz.Domain.Entities.Dto
{
    public class EtutDto :IDto
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime? EtutTarihi { get; set; }
    }
}
