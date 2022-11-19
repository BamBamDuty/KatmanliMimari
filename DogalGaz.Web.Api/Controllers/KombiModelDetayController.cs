using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.KombiModelDetay_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KombiModelDetayController : BaseController<IKombiModelDetayServices, KombiModelDetay, KombiModelDetayDto, KombiModelDetayRequest>
    {
        private readonly IKombiModelDetayServices _kombiModelDetay;

        public KombiModelDetayController(IKombiModelDetayServices kombiModelDetay) : base(kombiModelDetay)
        {
            _kombiModelDetay = kombiModelDetay;
        }

        [HttpGet]
        [Route("GetByTeklifId/{teklifId}")]
        public IQueryable<KombiModelDetay> GetByTeklifId(int teklifId)
        {
            return _kombiModelDetay.GetByTeklifIdAsync(teklifId);
        }


    }
}
