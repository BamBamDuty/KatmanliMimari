using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;

namespace DogalGaz.Domain.Entities.Entities
{
    public class DigerDetay : EntitiesModel, IEntity
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
