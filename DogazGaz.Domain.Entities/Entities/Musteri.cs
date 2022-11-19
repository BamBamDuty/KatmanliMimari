using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Entities
{
    public class Musteri : EntitiesModel, IEntity
    {
        public int ID { get; set; }

        public string AdSoyad { get; set; }
        public int? MusteriSiraNo { get; set; }
        public string BaglantiNumarasi { get; set; }
        public string TuketimNo { get; set; }
        public string SayacNo { get; set; }
        public bool IsDeleted { get; set ; }
    }
}
