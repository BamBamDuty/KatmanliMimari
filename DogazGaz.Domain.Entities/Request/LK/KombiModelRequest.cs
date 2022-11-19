using Base.Entities.Request;
using System;

namespace DogalGaz.Domain.Entities.Request
{
    public class KombiModelRequest:IRequest
    {
        public int ID { get; set; }
        public int KombiMarkaId { get; set; }
        public string Name { get; set; }
        public decimal Tutar { get; set; }
        public bool IsDeleted { get; set; }
        public int CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
