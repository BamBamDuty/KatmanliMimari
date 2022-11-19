using Base.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Dto
{
    public class KombiModelDto:IDto
    {
        public int ID { get; set; }
        public int KombiMarkaId { get; set; }
        public string Name { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
        public int CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
