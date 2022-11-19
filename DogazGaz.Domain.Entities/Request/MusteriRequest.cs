using Base.Entities.Request;

namespace DogalGaz.Domain.Entities.Request
{
    public class MusteriRequest:IRequest
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public int TeklifID { get; set; }
        public string Aciklama { get; set; }
        public double KrediKartiTutar { get; set; }
        public double NakitTutar { get; set; }
        public int? MusteriSiraNo { get; set; }
        public string BaglantiNumarasi { get; set; }
        public string TuketimNo { get; set; }
        public string SayacNo { get; set; }
    }
}
