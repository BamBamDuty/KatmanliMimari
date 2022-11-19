using Base.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Request
{
    public class DogalGazTesisatDetayRequest : IRequest
    {
        public int ID { get; set; }
        public string DogalGazTesisatName { get; set; }
        public string Tutar { get; set; }
    }
}
