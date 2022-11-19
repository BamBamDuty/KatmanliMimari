using Base.Entities.Dtos;
using System;

namespace DogalGaz.Domain.Entities.Dto.LK
{
    public class SobaMarkaDto : IDto
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public int CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public int UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}