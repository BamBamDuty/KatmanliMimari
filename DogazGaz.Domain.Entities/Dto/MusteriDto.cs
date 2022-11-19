using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
    public class MusteriDto:IDto
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public int? MusteriSiraNo { get; set; }
        public string BaglantiNumarasi { get; set; }
        public string TuketimNo { get; set; }
        public string SayacNo { get; set; }
    }
}
