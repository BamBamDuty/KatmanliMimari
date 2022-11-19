using Base.Entities.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogalGaz.Domain.Entities.Entities.LK
{
    [Table("KombiModel", Schema = "LK")]
    public class KombiModel:IEntity
    {
        public int ID { get; set; }
        public int KombiMarkaID{ get; set; }
        public string Name { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
