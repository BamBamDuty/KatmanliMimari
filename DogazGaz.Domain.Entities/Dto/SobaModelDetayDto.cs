using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class SobaModelDetayDto: IDto
    {
        public int ID { get; set; }
        public int SobaModelID { get; set; }
        public int SobaMarkaID { get; set; }
        public int TeklifID { get; set; }
        public int Tutar { get; set; }
    }
}
