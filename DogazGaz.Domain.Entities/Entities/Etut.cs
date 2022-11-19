using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;

namespace DogalGaz.Domain.Entities.Entities
{
    public class Etut : EntitiesModel, IEntity
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime? EtutTarihi { get; set; }
        public bool IsDeleted { get; set; }

    }
}
