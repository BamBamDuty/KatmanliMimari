using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class KombiModelDetayDto: IDto
    {
        public int ID { get; set; }
        public int KombiModelID { get; set; }
        public int KombiMarkaID { get; set; }
        public int TeklifID { get; set; }
        public int Tutar { get; set; }
    }
}
