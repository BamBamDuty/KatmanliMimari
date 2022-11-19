using Base.Entities.Request;
using System;

namespace DogalGaz.Domain.Entities.Request.LK
{
    public class SobaModelRequest : IRequest
    {
        public int ID { get; set; }
        public int SobaMarkaID { get; set; }
        public string Name { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
        public int CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
