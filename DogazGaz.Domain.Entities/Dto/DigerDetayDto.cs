using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class DigerDetayDto:IDto
    {
        public int ID { get; set; }
        public int DigerID { get; set; }
        public int TeklifID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
    }
}
