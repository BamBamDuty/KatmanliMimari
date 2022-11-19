using Base.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request
{
    public class DigerDetayRequest : IRequest
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
