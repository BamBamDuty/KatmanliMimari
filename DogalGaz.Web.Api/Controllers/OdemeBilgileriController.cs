using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.OdemeBilgileri_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdemeBilgileriController : BaseController<IOdemeBilgileriServices, OdemeBilgileri, OdemeBilgileriDto, OdemeBilgileriRequest>
    {
        private readonly IOdemeBilgileriServices _odemeBilgileri;
        public OdemeBilgileriController(IOdemeBilgileriServices odemeBilgileri) : base(odemeBilgileri)
        {
            _odemeBilgileri = odemeBilgileri;
        }

        [HttpGet]
        [Route("GetOdemeBilgileriByTeklifId")]
        public IQueryable<OdemeBilgileri> GetOdemeBilgileriByTeklifId([FromQuery] int teklifId)
        {
            return _odemeBilgileri.GetOdemeBilgileriByTeklifId(teklifId);
        }
    }
}
