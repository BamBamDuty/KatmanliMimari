using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.RadyatorDetay_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadyatorDetayController : BaseController<IRadyatorDetayServices, RadyatorDetay, RadyatorDetayDto, RadyatorDetayRequest>
    {
        private readonly IRadyatorDetayServices _radyatorDetay;

        public RadyatorDetayController(IRadyatorDetayServices radyatorDetay) : base(radyatorDetay)
        {
            _radyatorDetay = radyatorDetay;
        }

        [HttpGet]
        [Route("GetByTeklifId/{teklifId}")]
        public IQueryable<RadyatorDetay> GetByTeklifId(int teklifId)
        {
            return  _radyatorDetay.GetByTeklifIdAsync(teklifId);
        }

       
    }
}
