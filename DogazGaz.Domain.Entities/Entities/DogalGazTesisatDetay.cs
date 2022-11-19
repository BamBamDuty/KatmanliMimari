using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogalGaz.Domain.Entities.Entities
{
    public class DogalGazTesisatDetay : EntitiesModel, IEntity
    {
        public int ID { get; set; }

        public int TeklifID { get; set; }
        public int  DogalGazTesisatID { get; set; }
        public int Tutar { get; set; }
        public bool IsDeleted { get; set; }
    }
}
