using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogalGaz.Domain.Entities.Entities.LK
{
    [Table("SobaModel", Schema = "LK")]
    public class SobaModel : EntitiesModel, IEntity
    {
        public int ID { get; set; }
        public int SobaMarkaID { get; set; }
        public string Name { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
      

    }
}
