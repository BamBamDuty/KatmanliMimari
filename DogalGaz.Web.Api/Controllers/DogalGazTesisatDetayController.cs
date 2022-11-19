using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.DogalGazTesisatDetay_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogalGazTesisatDetayController : BaseController<IDogalGazTesisatDetayServices, DogalGazTesisatDetay, DogalGazTesisatDetayDto, DogalGazTesisatDetayRequest>
    {
        private readonly IDogalGazTesisatDetayServices _dogalGazTesisatDetay;

        public DogalGazTesisatDetayController(IDogalGazTesisatDetayServices dogalGazTesisatDetay) : base(dogalGazTesisatDetay)
        {
            _dogalGazTesisatDetay = dogalGazTesisatDetay;
        }

        [HttpGet]
        [Route("GetByTeklifId/{teklifId}")]
        public IQueryable<DogalGazTesisatDetay> GetByTeklifId(int teklifId)
        {
            return _dogalGazTesisatDetay.GetByTeklifIdAsync(teklifId);
        }

    }
}
