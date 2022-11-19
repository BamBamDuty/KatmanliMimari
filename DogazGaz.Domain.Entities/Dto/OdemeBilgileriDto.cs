using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
  public  class OdemeBilgileriDto: IDto
    {
        public int ID { get; set; }
        public int TeklifID { get; set; }
        public string Aciklama { get; set; }
        public int KrediKartiTutar { get; set; }
        public int NakitTutar { get; set; }
    }
}
