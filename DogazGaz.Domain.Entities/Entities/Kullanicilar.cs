using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Entities
{
   public class Kullanicilar : EntitiesModel, IEntity
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciTipi { get; set; }
        public bool IsDeleted { get; set; }

    }
}
