using Base.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request
{
    public class SobaModelDetayRequest : IRequest
    {
        public int ID { get; set; }
        public int SobaModelID { get; set; }
        public int SobaMarkaID { get; set; }
        public int TeklifID { get; set; }
        public int Tutar { get; set; }
    }
}
