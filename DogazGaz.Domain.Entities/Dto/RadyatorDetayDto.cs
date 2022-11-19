using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
    public class RadyatorDetayDto : IDto
    {
        public int ID { get; set; }
        public int RadyatorID { get; set; }
        public string Metre { get; set; }
        public int Tutar { get; set; }
    }
}
