using Base.Entities.Entities;
using DogalGaz.Domain.Entities.Entities.Models;

namespace DogalGaz.Domain.Entities.Entities
{
    public class OdemeBilgileri : EntitiesModel, IEntity
    {
        public int ID { get; set; }
        public int TeklifID { get; set; }
        public string Aciklama { get; set; }
        public double KrediKartiTutar { get; set; }
        public double NakitTutar { get; set; }
        public bool IsDeleted { get; set; }

    }
}
