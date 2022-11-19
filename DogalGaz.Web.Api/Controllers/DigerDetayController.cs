using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.DigerDetay_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigerDetayController : BaseController<IDigerDetayServices, DigerDetay, DigerDetayDto, DigerDetayRequest>
    {
        private readonly IDigerDetayServices _digerDetay;

        public DigerDetayController(IDigerDetayServices digerDetay) : base(digerDetay)
        {
            _digerDetay =digerDetay;
        }

        [HttpGet]
        [Route("GetByTeklifId/{id}")]
        public IQueryable<DigerDetay> GetByTeklifId(int id)
        {
            return  _digerDetay.GetByTeklifIdAsync(id);
        }
    }
}

