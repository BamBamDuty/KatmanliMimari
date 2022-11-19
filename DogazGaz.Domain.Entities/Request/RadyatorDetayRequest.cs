using Base.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request
{
    public class RadyatorDetayRequest : IRequest
    {
        public int ID { get; set; }
        public int TeklifID { get; set; }
        public string RadyatorName { get; set; }
        public string Metre { get; set; }
        public int Tutar { get; set; }
    }
}
