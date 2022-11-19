using Base.Entities.Request;
using System;

namespace DogalGaz.Domain.Entities.Request
{
    public  class EtutRequest : IRequest
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime EtutTarihi { get; set; }
    }
}
