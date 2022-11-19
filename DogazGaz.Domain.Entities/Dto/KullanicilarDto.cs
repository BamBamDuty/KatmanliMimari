using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class KullanicilarDto : IDto
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciTipi { get; set; }
    }
}
