using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
   public class DogalGazTesisatDetayDto: IDto
    {
        public int ID { get; set; }
        public int TeklifID { get; set; }
        public string DogalGazTesisatName { get; set; }
        public string Tutar { get; set; }
        public bool IsDeleted { get; set; }
    }
}
